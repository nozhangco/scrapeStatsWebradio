using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class StarPrinterWrapper : StarIO10ObjectWrapper<StarPrinter>
    {
        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterCommunicationError { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterReady { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterError { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterPaperReady { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterPaperNearEmpty { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterPaperEmpty { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterCoverOpened { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> PrinterCoverClosed { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> DrawerCommunicationError { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> DrawerOpenCloseSignalSwitched { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> InputDeviceCommunicationError { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> InputDeviceConnected { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> InputDeviceDisconnected { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> InputDeviceDataReceived { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> DisplayCommunicationError { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> DisplayConnected { get; set; }

        [ReactEvent]
        public Action<IReadOnlyDictionary<string, JSValue>> DisplayDisconnected { get; set; }

        [ReactMethod("init")]
        public void Init(IReactPromise<string> promise)
        {
            StarPrinter nativeObject = new StarPrinter(new StarConnectionSettings(InterfaceType.Unknown));

            SetObject(nativeObject, out string objectIdentifier);

            nativeObject.PrinterDelegate.CommunicationError += (sender, e) =>
            {
                StarIO10ErrorWrapper.SetObject(e.Exception, out string exceptionIdentifier);

                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);
                parameter.Add(EventParameter.KeyErrorIdentifier, exceptionIdentifier);

                PrinterCommunicationError(parameter);
            };

            nativeObject.DrawerDelegate.CommunicationError += (sender, e) =>
            {
                StarIO10ErrorWrapper.SetObject(e.Exception, out string exceptionIdentifier);

                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);
                parameter.Add(EventParameter.KeyErrorIdentifier, exceptionIdentifier);

                DrawerCommunicationError(parameter);
            };

            nativeObject.InputDeviceDelegate.CommunicationError += (sender, e) =>
            {
                StarIO10ErrorWrapper.SetObject(e.Exception, out string exceptionIdentifier);

                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);
                parameter.Add(EventParameter.KeyErrorIdentifier, exceptionIdentifier);

                InputDeviceCommunicationError(parameter);
            };

            nativeObject.DisplayDelegate.CommunicationError += (sender, e) =>
            {
                StarIO10ErrorWrapper.SetObject(e.Exception, out string exceptionIdentifier);

                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);
                parameter.Add(EventParameter.KeyErrorIdentifier, exceptionIdentifier);

                DisplayCommunicati