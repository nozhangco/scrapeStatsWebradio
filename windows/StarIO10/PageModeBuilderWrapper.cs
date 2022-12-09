﻿using Microsoft.ReactNative.Managed;
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
                return;
            }

            nativeObject.StyleFont(nativeType);

            promise.Resolve();
        }

        [ReactMethod("styleBold")]
        public void StyleBold(string objectIdentifier, bool enable, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject) ||
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleLineSpace(height);

            promise.Resolve();
        }

        [ReactMethod("styleVerticalPositionTo")]
        public void StyleVerticalPositionTo(string objectIdentifier, double position, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleVerticalPositionTo(position);

            promise.Resolve();
        }

        [ReactMethod("styleVerticalPositionBy")]
        public void StyleVerticalPositionBy(string objectIdentifier, double position, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleVerticalPositionBy(position);

            promise.Resolve();
        }

        [ReactMethod("styleHorizontalPositionTo")]
        public void StyleHorizontalPositionTo(string objectIdentifier, double position, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
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
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject) ||
                !StarIO10ValueConverter.ToPrinterInternationalCharacterType(type, out InternationalCharacterType nativeType))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleInternationalCharacter(nativeType);

            promise.Resolve();
        }

        [ReactMethod("styleSecondPriorityCharacterEncoding")]
        public void StyleSecondPriorityCharacterEncoding(string objectIdentifier, string type, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject) ||
                !StarIO10ValueConverter.ToPrinterCharacterEncodingType(type, out CharacterEncodingType nativeType))
            {
                promise.Reject(new ReactError());
                return;
            }

            nativeObject.StyleSecondPriorityCharacterEncoding(nativeType);

            promise.Resolve();
        }

        [ReactMethod("styleCjkCharacterPriority")]
        public void StyleCjkCharacterPriority(string objectIdentifier, string[] types, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilder nativeObject))
            {
                promise.Reject(new ReactError());
                return;
            }

            List<CjkCharacterType> nativeTypeList = new List<CjkCharacterType>();

            foreach (string type in types)
            {
                if (!StarIO10ValueConverter.ToPrinterCjkCharacterType(type, out CjkCharacterType nativeType))
                {
                    promise.Reject(new ReactError());
                    return;
                }

                nativeTypeList.Add(nativeType);
            }

            nativeObject.StyleCjkCharacterPriority(nativeTypeList);

            promise.Resolve();
        }

        [ReactMethod("actionPrintText")]
        public void ActionPrintText(string objectIdentifier, string content, IReactPromise<JSValue.Void> promise)
        {
            if (!GetObject(objectIdentifier, out PageModeBuilde