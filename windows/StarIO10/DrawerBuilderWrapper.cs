using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.Drawer;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class DrawerBuilderWrapper : StarIO10ObjectWrapper<DrawerBuilder>
    {
        [ReactMethod("init")]
 