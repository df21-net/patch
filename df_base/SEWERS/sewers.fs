void sewersCameraChange1()
{
	player.disableActions(ACTION_ALL);
	level.getObject("gates_cam1").setCamera();
}

void sewersCameraChange2()
{
	player.disableActions(ACTION_ALL);
	level.getObject("gates_cam2").setCamera();
}
