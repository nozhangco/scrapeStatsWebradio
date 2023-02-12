using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10.StarXpandCommand;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class StarXpandCommandBuilderWrapper : StarIO10ObjectWrapper<StarXpandCommandBuilder>
    {
        [ReactMethod("init")]
        public void Init(IReactPromise<string> promise)
        {
            StarXpandCommandBuilder nativeObject = new StarXpandCommandBuilder();

            SetObject(nativeObject, out string objectIdentifier);

            promise.Resolve(objectIdentifier);
        }

        [ReactMethod("dispose")]
        public void Dispose(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            DisposeObject(objectIdentifier);

            promise.Resolve();
        }

        [ReactMethod("setPreSetting")]
        public void SetPreSetting(string objectIdentifier, string preSettingBuilderIdentifier, IReactPromise<JSValue.Void> promise)
        {
         