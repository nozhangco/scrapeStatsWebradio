using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.Printer;
using System;
using System.Collections.Generic;

namespace StarMicronics.ReactNative.StarIO10
{
    [ReactModule]
    class PageModeBuilderWrapper : StarIO10ObjectWrapper<PageModeBuilder>
    {
        [ReactMethod("init")]
        public void Init(IReactPromise<string> promise)
        {
            PageModeBuilder nativeObject = new PageModeBuilder();

            SetObject(nativeObject, out string objectIdentifier);

            promise.Resolve(objectIdentifier);
        }

        [ReactMethod("dispose")]
        public void Dispose(string objectIdentifier, IReactPromise<JSValue.Void> promise)
        {
            DisposeObject(objectIdentifier);

            promise.Resolve();
        }

        [ReactMethod("stylePrintDirection")]
        public void StylePrintDirection(string objectIdentifier, string direction, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject) ||
                !StarIO10ValueConverter.ToPrinterPageModePrintDirection(direction, out PageModePrintDirection nativeDirection))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StylePrintDirection(nativeDirection);

            promise.Resolve();
        }

        [ReactMethod("styleFont")]
        public void StyleFont(string objectIdentifier, string type, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject) ||
                !StarIO10ValueConverter.ToPrinterFontType(type, out FontType nativeType))
            {
                promise.Reject(new ReactError());
              