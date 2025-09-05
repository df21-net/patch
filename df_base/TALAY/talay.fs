void startTalayOpeningCinematic()
{
	player.disableActions(ACTION_ALL);
	level.getObject("opening_cam").setCamera();
}

void endTalayOpeningCinematic()
{
	player.setCamera();
	player.enableActions(ACTION_ALL);
}

void lightsCinematicA()
{
	player.disableActions(ACTION_ALL);
	level.getObject("lights_camA").setCamera();
}

void lightsCinematicB()
{
	level.getObject("lights_camB").setCamera();
}

void lightsCinematicC()
{
	level.getObject("lights_camC").setCamera();
}
