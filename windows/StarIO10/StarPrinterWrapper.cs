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

                DisplayCommunicationError(parameter);
            };

            promise.Resolve(objectIdentifier);
        }

        [ReactMethod("dispose")]
        public void Dispose(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            DisposeObject(objectIdentifier);

            promise.Resolve();
        }

        [ReactMethod("addListener")]
        public void AddListener(string objectIdentifier, string eventName, IReactPromise<JSValue.Void> promise)
        {
            promise.Resolve();
        }

        [ReactMethod("removeListeners")]
        public void RemoveListeners(string objectIdentifier, int count, IReactPromise<JSValue.Void> promise)
        {
            promise.Resolve();
        }
        
        [ReactMethod("activatePrinterDelegate")]
        public void ActivatePrinterDelegate(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out StarPrinter nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.PrinterDelegate.Ready += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                PrinterReady(parameter);
            };

            nativeObject.PrinterDelegate.Error += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                PrinterError(parameter);
            };

            nativeObject.PrinterDelegate.PaperReady += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                PrinterPaperReady(parameter);
            };

            nativeObject.PrinterDelegate.PaperNearEmpty += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                PrinterPaperNearEmpty(parameter);
            };

            nativeObject.PrinterDelegate.PaperEmpty += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                PrinterPaperEmpty(parameter);
            };

            nativeObject.PrinterDelegate.CoverOpened += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                PrinterCoverOpened(parameter);
            };

            nativeObject.PrinterDelegate.CoverClosed += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                PrinterCoverClosed(parameter);
            };

            promise.Resolve();
        }

        [ReactMethod("activateDrawerDelegate")]
        public void ActivateDrawerDelegate(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out StarPrinter nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.DrawerDelegate.OpenCloseSignalSwitched += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);
                parameter.Add(EventParameter.KeyDrawerOpenCloseSignalState, e.OpenCloseSignal);

                DrawerOpenCloseSignalSwitched(parameter);
            };

            promise.Resolve();
        }

        [ReactMethod("activateInputDeviceDelegate")]
        public void ActivateInputDeviceDelegate(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out StarPrinter nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.InputDeviceDelegate.Connected += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                InputDeviceConnected(parameter);
            };

            nativeObject.InputDeviceDelegate.Disconnected += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);

                InputDeviceDisconnected(parameter);
            };

            nativeObject.InputDeviceDelegate.DataReceived += (sender, e) =>
            {
                var parameter = new Dictionary<string, JSValue>();
                parameter.Add(EventParameter.KeyIdentifier, objectIdentifier);
                parameter.Add(EventParameter.KeyInputDeviceData, StarIO10ValueConverter.ToJSValue(e.Data.ToArray()));

                InputDeviceDataReceived(parameter);
            };

            promise.Resolve();
        }

        [ReactMeth