void testbaseOpeningCinematic()
{
    player.disableActions(ACTION_ALL);
    level.getObject("start_cam").setCamera();
}

void testbaseCam(string name)
{
    player.disableActions(ACTION_ALL);
    level.getObject(name).setCamera();
}