#include "talay.fs"
#include "sewers.fs"

void levelStart(string levelName)
{
	system.print("Starting {}", levelName);
}

void levelUpdate(float dt)
{
}

void cameraToPlayer()
{
	player.setCamera();
	player.enableActions(ACTION_ALL);
}
