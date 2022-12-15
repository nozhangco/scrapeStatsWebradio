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
        public void AddPageMode(string objectIdentifier, double x, double y, double width, double height, string pageModeBuilderIdentifier, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject) ||
                !PageModeBuilderWrapper.GetObject(pageModeBuilderIdentifier, out PageModeBuilder pageModeBuilder) ||
                !StarIO10ValueConverter.ToPrinterPageModeAreaParameter(x, y, width, height, out PageModeAreaParameter nativeParameter))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.AddPageMode(nativeParameter, pageModeBuilder);

            promise.Resolve();
        }

        [ReactMethod("styleFont")]
        public void StyleFont(string objectIdentifier, string type, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject) ||
                !StarIO10ValueConverter.ToPrinterFontType(type, out FontType nativeType))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleFont(nativeType);

            promise.Resolve();
        }

        [ReactMethod("styleBold")]
        public void StyleBold(string objectIdentifier, bool enable, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleBold(enable);

            promise.Resolve();
        }

        [ReactMethod("styleInvert")]
        public void StyleInvert(string objectIdentifier, bool enable, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleInvert(enable);

            promise.Resolve();
        }

        [ReactMethod("styleUnderLine")]
        public void StyleUnderLine(string objectIdentifier, bool enable, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleUnderLine(enable);

            promise.Resolve();
        }

        [ReactMethod("styleMagnification")]
        public void StyleMagnification(string objectIdentifier, int width, int height, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject) ||
                !StarIO10ValueConverter.ToMagnificationParameter(width, height, out MagnificationParameter parameter))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleMagnification(parameter);

            promise.Resolve();
        }

        [ReactMethod("styleCharacterSpace")]
        public void StyleCharacterSpace(string objectIdentifier, double width, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleCharacterSpace(width);

            promise.Resolve();
        }

        [ReactMethod("styleLineSpace")]
        public void StyleLineSpace(string objectIdentifier, double height, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleLineSpace(height);

            promise.Resolve();
        }

        [ReactMethod("styleHorizontalPositionTo")]
        public void StyleHorizontalPositionTo(string objectIdentifier, double position, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleHorizontalPositionTo(position);

            promise.Resolve();
        }

        [ReactMethod("styleHorizontalPositionBy")]
        public void StyleHorizontalPositionBy(string objectIdentifier, double position, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleHorizontalPositionBy(position);

            promise.Resolve();
        }

        [ReactMethod("styleHorizontalTabPositions")]
        public void StyleHorizontalTabPositions(string objectIdentifier, int[] positions, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleHorizontalTabPositions(positions);

            promise.Resolve();
        }

        [ReactMethod("styleInternationalCharacter")]
        public void StyleInternationalCharacter(string objectIdentifier, string type, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PrinterBuilder nativeObject) ||
                !StarIO10ValueConverter.ToPrinterInternationalCharacterType(type, out InternationalCharacterType nativeType))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleInternationalCharacter(nativeType);

            promise.Resolve();
        }

        [ReactMethod("styleSecondPriorityCharacterEncodin