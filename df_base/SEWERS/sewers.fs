void cameraChange1()
{
	player.disableActions(ACTION_ALL);
	level.getObject("gates_cam1").setCamera();
}

void cameraChange2()
{
	player.disableActions(ACTION_ALL);
	level.getObject("gates_cam2").setCamera();
}

void cameraToPlayer()
{
	player.setCamera();
	player.enableActions(ACTION_ALL);
}