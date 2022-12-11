using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.Printer;
using System;
using System.Collections.Generic;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class PrinterBuilderWrapper : StarIO10ObjectWrapper<PrinterBuilder>
    {
        [ReactMethod("init")]
        public void Init(IReactPromise<string> promise)
        {
            PrinterBuilder nativeObject = new PrinterBuilder();

            SetObject(nativeObject, out string objectIdentifier);

            promise.Resolve(objectIdentifier);
        }

        [ReactMethod("dispose")]
        public void Dispose(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            DisposeObject(objectIdentifier);

            promise.Resolve();
        }

        [ReactMethod("styleAlignment")]
        public void StyleAlignment(string objectIdentifier, string alignment, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject) ||
                !StarIO10ValueConverter.ToPrinterAlignment(alignment, out Alignment nativeAlignment))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleAlignment(nativeAlignment);

            promise.Resolve();
        }

        [ReactMethod("addPageMode")]
        public void AddPageMode(string objectIdentifier, double x, double y, double width, double height, string pageModeBuilderIdentifier, IReactPromise<JSV