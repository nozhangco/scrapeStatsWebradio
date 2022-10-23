using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.Buzzer;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class BuzzerBuilderWrapper : StarIO10ObjectWrapper<BuzzerBuilder>
    {
        [ReactMethod("init")]
        public void Init(IReactPromise<string> promise)
        {
            BuzzerBuilder nativeObject = new BuzzerBuilder();

            SetObject(nativeObject, out string objectIdentifier);

            promise.Resolve(objectIdent