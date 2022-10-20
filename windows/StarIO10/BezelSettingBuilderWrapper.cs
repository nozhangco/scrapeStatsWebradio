using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.Bezel;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class BezelSettingBuilderWrapper : StarIO10ObjectWrapper<BezelSettingBuilder>
    {
        [ReactMethod("init")]
        public void Init(IReactPromise<string> promise)
        {
            BezelSettingBuilder nativeObject = new BezelSettingBuilder();

            SetObject(nativeObject, out string objectIdentifier);

            promise.Resolve(objectIdentifier);
        }

        [ReactMethod("dispose")]
        public void Dispose(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            DisposeObject(objectIdentifier);

            promise.Resolve();
        }

        [ReactMethod("settingAutomaticPageLength")]
        public void SettingAutomaticPageLength(string objectIdentifier, bool enable, IReact