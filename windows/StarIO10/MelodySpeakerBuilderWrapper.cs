using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.MelodySpeaker;
using System;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class MelodySpeakerBuilderWrapper : StarIO10ObjectWrapper<MelodySpeakerBuilder>
    {
        [ReactMethod("init")]
        public void Init(IReactPromise<string> promise)
        {
            MelodySpeakerBuilder nativeObject = new MelodySpeakerBuilder();

            SetObject(nativeObject, out string objectIdentifier);

            promise.Resolve(objectIdentifier);
 