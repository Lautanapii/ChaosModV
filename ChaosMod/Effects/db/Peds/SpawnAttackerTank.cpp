/*
    Effect by <Tiktok:lautanapii_>
*/

#include <stdafx.h>

static Vehicle tank;
static Ped driver;

static void LoadModel(Hash model) {
    REQUEST_MODEL(model);
    while (!HAS_MODEL_LOADED(model)) {
        WAIT(100);
    }
}

static void CreateTankAndDriver() {
    Player player = PLAYER_ID();
    Ped playerPed = PLAYER_PED_ID();
    Vector3 playerPos = GET_ENTITY_COORDS(playerPed, true);

    // Define spawn position relative to the player
    Vector3 spawnPos = { playerPos.x + 10.0f, playerPos.y, playerPos.z };

    // Load tank and driver models
    Hash tankModel = GAMEPLAY::GET_HASH_KEY("rhino");
    Hash driverModel = GAMEPLAY::GET_HASH_KEY("s_m_y_swat_01");

    LoadModel(tankModel);
    LoadModel(driverModel);

    // Create the tank and the driver
    tank = CREATE_VEHICLE(tankModel, spawnPos.x, spawnPos.y, spawnPos.z, 0.0f, true, true, false);
    driver = CREATE_PED_INSIDE_VEHICLE(tank, 26, driverModel, -1, true, true);

    // Set the tank to attack the player
