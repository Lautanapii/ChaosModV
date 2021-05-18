/*
	Effect by Moxi based on "Killer Clowns" by Last0xygen
*/

#include <stdafx.h>

static std::list<Ped> cougarEnemies;
static int spawnTimer = -1;
static Hash relationshipGroup;
static int maxCougarsToSpawn = 3;

static Vector3 getRandomOffsetCoord(Vector3 startCoord, int minOffset, int maxOffset)
{
	Vector3 randomCoord;
	randomCoord.z = startCoord.z;
	float groundZ;
	for (int i = 0; i < 10; i++) {
		if (g_random.GetRandomInt(0, 1) % 2 == 0)
		{
			randomCoord.x = startCoord.x + g_random.GetRandomInt(minOffset, maxOffset);
		}
		else
		{
			randomCoord.x = startCoord.x - g_random.GetRandomInt(minOffset, maxOffset);
		}
		if (g_random.GetRandomInt(0, 1) % 2 == 0)
		{
			randomCoord.y = startCoord.y + g_random.GetRandomInt(minOffset, maxOffset);
		}
		else
		{
			randomCoord.y = startCoord.y - g_random.GetRandomInt(minOffset, maxOffset);
		}
		randomCoord.z = startCoord.z;
		if (GET_GROUND_Z_FOR_3D_COORD(randomCoord.x, randomCoord.y, randomCoord.z, &groundZ, false, false))
		{
			randomCoord.z = groundZ;
			break;
		}
	}
	return randomCoord;
}

static void OnStop()
{
	REMOVE_NAMED_PTFX_ASSET("des_trailerpark");

	for (Ped ped : cougarEnemies)
	{
		SET_PED_AS_NO_LONGER_NEEDED(&ped);
	}

	cougarEnemies.clear();
}

static void OnStart()
{
	static const Hash playerGroup = GET_HASH_KEY("PLAYER");
	ADD_RELATIONSHIP_GROUP("_HOSTILE_HOT_COUGARS", &relationshipGroup);
	SET_RELATIONSHIP_BETWEEN_GROUPS(5, relationshipGroup, playerGroup);
	SET_RELATIONSHIP_BETWEEN_GROUPS(5, playerGroup, relationshipGroup);
	SET_RELATIONSHIP_BETWEEN_GROUPS(0, relationshipGroup, relationshipGroup);
}

static void OnTick()
{
	REQUEST_NAMED_PTFX_ASSET("des_trailerpark");
	while (!HAS_NAMED_PTFX_ASSET_LOADED("des_trailerpark"))
	{
		WAIT(0);
	}

	Ped playerPed = PLAYER_PED_ID();
	Vector3 playerPos = GET_ENTITY_COORDS(playerPed, false);
	int current_time = GET_GAME_TIMER();

	for (std::list<Entity>::iterator it = cougarEnemies.begin(); it != cougarEnemies.end(); )
	{
		Ped cougar = *it;
		Vector3 cougarPos = GET_ENTITY_COORDS(cougar, false);
		if (IS_PED_DEAD_OR_DYING(cougar, false) || IS_PED_INJURED(cougar) || GET_DISTANCE_BETWEEN_COORDS(playerPos.x, playerPos.y, playerPos.z, cougarPos.x, cougarPos.y, cougarPos.z, false) > 100.f)
		{
			SET_ENTITY_HEALTH(cougar, 0, 0);
			USE_PARTICLE_FX_ASSET("core");
			START_PARTICLE_FX_NON_LOOPED_AT_COORD("exp_air_molotov", cougarPos.x, cougarPos.y, cougarPos.z, 0, 0, 0, 3, false, false, false);
			WAIT(300);
			SET_ENTITY_ALPHA(cougar, 0, true);
			SET_PED_AS_NO_LONGER_NEEDED(&cougar);
			DELETE_PED(&cougar);
			it = cougarEnemies.erase(it);
			WAIT(0);
		}
		else
		{
			it++;
		}
	}

	if (cougarEnemies.size() < maxCougarsToSpawn && current_time > spawnTimer + 2000)
	{
		spawnTimer = current_time;
		Vector3 spawnPos = getRandomOffsetCoord(playerPos, 10, 25);
		USE_PARTICLE_FX_ASSET("core");
		START_PARTICLE_FX_NON_LOOPED_AT_COORD("exp_air_molotov", spawnPos.x, spawnPos.y, spawnPos.z, 0, 0, 0, 2, true, true, true);
		WAIT(300);
		Hash cougarHash = GET_HASH_KEY("a_c_mtlion");
		LoadModel(cougarHash);
		Ped ped = CREATE_PED(-1, cougarHash, spawnPos.x, spawnPos.y, spawnPos.z, 0, true, false);
		SET_ENTITY_PROOFS(ped, false, true, false, false, false, false, false, false);
		SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(ped, true);
		SET_PED_RELATIONSHIP_GROUP_HASH(ped, relationshipGroup);
		SET_PED_HEARING_RANGE(ped, 9999.f);
		TASK_COMBAT_PED(ped, playerPed, 0, 16);
		USE_PARTICLE_FX_ASSET("des_trailerpark");
		START_PARTICLE_FX_LOOPED_ON_ENTITY("ent_ray_trailerpark_fires", ped, 0.f, 0.f, 0.f, 0.f, 0.f, 0.f, .5f, false, false, false);
		cougarEnemies.push_back(ped);
	}
}

static RegisterEffect registerEffect(EFFECT_HOT_COUGARS, OnStart, OnStop, OnTick, EffectInfo
	{
		.Name = "Hot Cougars In Your Area",
		.Id = "peds_hotcougars",
		.IsTimed = true,
		.IsShortDuration = true
	}
);