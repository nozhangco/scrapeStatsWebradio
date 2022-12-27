﻿using Microsoft.ReactNative.Managed;
using StarMicronics.StarIO10;
using StarMicronics.StarIO10.StarXpandCommand;
using StarMicronics.StarIO10.StarXpandCommand.Buzzer;
using StarMicronics.StarIO10.StarXpandCommand.Display;
using StarMicronics.StarIO10.StarXpandCommand.Drawer;
using StarMicronics.StarIO10.StarXpandCommand.MelodySpeaker;
using StarMicronics.StarIO10.StarXpandCommand.Presenter;
using StarMicronics.StarIO10.StarXpandCommand.Printer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;

namespace StarMicronics.ReactNative.StarIO10
{
    internal class StarIO10ValueConverter
    {
        private static readonly IReadOnlyDictionary<InterfaceType, string> InterfaceTypeDictionary = new Dictionary<InterfaceType, string>()
        {
            { InterfaceType.Lan, "Lan" },
            { InterfaceType.Bluetooth, "Bluetooth" },
            { InterfaceType.BluetoothLE, "BluetoothLE" },
            { InterfaceType.Usb, "Usb" }
        };

        private static readonly IReadOnlyDictionary<StarPrinterModel, string> StarPrinterModelDictionary = new Dictionary<StarPrinterModel, string>()
        {
            { StarPrinterModel.Unknown, "Unknown" },
            { StarPrinterModel.TSP650II, "TSP650II" },
            { StarPrinterModel.TSP700II, "TSP700II" },
            { StarPrinterModel.TSP800II, "TSP800II" },
            { StarPrinterModel.TSP100IIIW, "TSP100IIIW" },
            { StarPrinterModel.TSP100IIILAN, "TSP100IIILAN" },
            { StarPrinterModel.TSP100IIIBI, "TSP100IIIBI" },
            { StarPrinterModel.TSP100IIIU, "TSP100IIIU" },
            { StarPrinterModel.TSP100IV, "TSP100IV" },
            { StarPrinterModel.mPOP, "mPOP" },
            { StarPrinterModel.mCPrint2, "mC_Print2" },
            { StarPrinterModel.mCPrint3, "mC_Print3" },
            { StarPrinterModel.SMS210i, "SM_S210i" },
            { StarPrinterModel.SMS230i, "SM_S230i" },
            { StarPrinterModel.SMT300,  "SM_T300" },
            { StarPrinterModel.SMT300i, "SM_T300i" },
            { StarPrinterModel.SMT400i, "SM_T400i" },
            { StarPrinterModel.SML200, "SM_L200" },
            { StarPrinterModel.SML300, "SM_L300" },
            { StarPrinterModel.BSC10, "BSC10" },
            { StarPrinterModel.TSP043, "TSP043" },
            { StarPrinterModel.SP700, "SP700" },
            { StarPrinterModel.TUP500, "TUP500" },
            { StarPrinterModel.SK12xx, "SK1_2xx" },
            { StarPrinterModel.SK13xx, "SK1_3xx" }
        };

        private static readonly IReadOnlyDictionary<StarPrinterEmulation, string> StarPrinterEmulationDictionary = new Dictionary<StarPrinterEmulation, string>()
        {
            { StarPrinterEmulation.Unknown, "Unknown" },
            { StarPrinterEmulation.StarLine, "StarLine" },
            { StarPrinterEmulation.StarDot, "StarDot" },
            { StarPrinterEmulation.StarGraphic, "StarGraphic" },
            { StarPrinterEmulation.StarPRNT, "StarPRNT" },
            { StarPrinterEmulation.EscPos, "EscPos" },
            { StarPrinterEmulation.EscPosMobile, "EscPosMobile" }
        };

        private static readonly IReadOnlyDictionary<StarMicronics.StarIO10.StarXpandCommand.Bezel.LedType, string> BezelLedTypeDictionary = new Dictionary<StarMicronics.StarIO10.StarXpandCommand.Bezel.LedType, string>()
        {
            { StarMicronics.StarIO10.StarXpandCommand.Bezel.LedType.Holding, "Holding" },
            { StarMicronics.StarIO10.StarXpandCommand.Bezel.LedType.Error, "Error" },
            { StarMicronics.StarIO10.StarXpandCommand.Bezel.LedType.Idle, "Idle" }
        };

        private static readonly IReadOnlyDictionary<StarMicronics.StarIO10.StarXpandCommand.Presenter.LedType, string> PresenterLedTypeDictionary = new Dictionary<StarMicronics.StarIO10.StarXpandCommand.Presenter.LedType, string>()
        {
            { StarMicronics.StarIO10.StarXpandCommand.Presenter.LedType.Holding, "Holding" },
            { StarMicronics.StarIO10.StarXpandCommand.Presenter.LedType.Error, "Error" },
            { StarMicronics.StarIO10.StarXpandCommand.Presenter.LedType.Idle, "Idle" }
        };

        private static readonly IReadOnlyDictionary<BlackMarkPosition, string> PrinterBlackMarkPositionDictionary = new Dictionary<BlackMarkPosition, string>()
        {
            { BlackMarkPosition.Front, "Front" },
            { BlackMarkPosition.Back, "Back" }
        };

        private static readonly IReadOnlyDictionary<Alignment, string> PrinterAlignmentDictionary = new Dictionary<Alignment, string>()
        {
            { Alignment.Left, "Left" },
            { Alignment.Center, "Center" },
            { Alignment.Right, "Right" }
        };

        private static readonly IReadOnlyDictionary<PageModePrintDirection, string> PrinterPageModePrintDirectionDictionary = new Dictionary<PageModePrintDirection, string>()
        {
            { PageModePrintDirection.BottomToTop, "BottomToTop" },
            { PageModePrintDirection.LeftToRight, "LeftToRight" },
            { PageModePrintDirection.RightToLeft, "RightToLeft" },
            { PageModePrintDirection.TopToBottom, "TopToBottom" },
        };

        private static readonly IReadOnlyDictionary<FontType, string> PrinterFontTypeDictionary = new Dictionary<FontType, string>()
        {
            { FontType.A, "A" },
            { FontType.B, "B" },
        };

        private static readonly IReadOnlyDictionary<StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType, string> PrinterInternationalCharacterTypeDictionary = new Dictionary<StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType, string>()
        {
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Usa, "Usa" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.France, "France" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Germany, "Germany" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.UK, "UK" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Denmark, "Denmark" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Sweden, "Sweden" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Italy, "Italy" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Spain, "Spain" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Japan, "Japan" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Norway, "Norway" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Denmark2, "Denmark2" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Spain2, "Spain2" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.LatinAmerica, "LatinAmerica" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Korea, "Korea" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Ireland, "Ireland" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Slovenia, "Slovenia" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Croatia, "Croatia" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.China, "China" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Vietnam, "Vietnam" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Arabic, "Arabic" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.InternationalCharacterType.Legal, "Legal" },
        };

        private static readonly IReadOnlyDictionary<StarMicronics.StarIO10.StarXpandCommand.Printer.CharacterEncodingType, string> PrinterCharacterEncodingTypeDictionary = new Dictionary<StarMicronics.StarIO10.StarXpandCommand.Printer.CharacterEncodingType, string>()
        {
            { StarMicronics.StarIO10.StarXpandCommand.Printer.CharacterEncodingType.Japanese, "Japanese" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.CharacterEncodingType.SimplifiedChinese, "SimplifiedChinese" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.CharacterEncodingType.TraditionalChinese, "TraditionalChinese" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.CharacterEncodingType.Korean, "Korean" },
            { StarMicronics.StarIO10.StarXpandCommand.Printer.CharacterEncodingType.CodePage, "CodePage" },
        };

        private static readonly IReadOnlyDictionary<CjkCharacterType, string> PrinterCjkCharacterTypeDictionary = new Dictionary<CjkCharacterType, string>()
        {
            { CjkCharacterType.Japanese, "Japanese" },
            { CjkCharacterType.SimplifiedChinese, "SimplifiedChinese" },
            { CjkCharacterType.TraditionalChinese, "TraditionalChinese" },
            { CjkCharacterType.Korean, "Korean" },
        };

        private static readonly IReadOnlyDictionary<CutType, string> PrinterCutTypeDictionary = new Dictionary<CutType, string>()
        {
            { CutType.Full, "Full" },
            { CutType.Partial, "Partial" },
            { CutType.FullDirect, "FullDirect" },
            { CutType.PartialDirect, "PartialDirect" },
        };

        private static readonly IReadOnlyDictionary<BarcodeSymbology, string> PrinterBarcodeSymbologyDictionary = new Dictionary<BarcodeSymbology, string>()
        {
            { BarcodeSymbology.UpcE, "UpcE" },
            { BarcodeSymbology.UpcA, "UpcA" },
            { BarcodeSymbology.Jan8, "Jan8" },
            { BarcodeSymbology.Ean8, "Ean8" },
            { BarcodeSymbology.Jan13, "Jan13" },
            { BarcodeSymbology.Ean13, "Ean13" },
            { BarcodeSymbology.Code39, "Code39" },
            { BarcodeSymbology.Itf, "Itf" },
            { BarcodeSymbology.Code128, "Code128" },
            { BarcodeSymbology.Code93, "Code93" },
            { BarcodeSymbology.NW7, "NW7" },
        };

        private static readonly IReadOnlyDictionary<BarcodeBarRatioLevel, string> PrinterBarcodeBarRatioLevelDictionary = new Dictionary<BarcodeBarRatioLevel, string>()
        {
            { BarcodeBarRatioLevel.LevelPlus1, "LevelPlus1" },
            { BarcodeBarRatioLevel.Level0, "Level0" },
            { BarcodeBarRatioLevel.LevelMinus1, "LevelMinus1" },
        };

        private static readonly IReadOnlyDictionary<Pdf417Level, string> PrinterPdf417LevelDictionary = new Dictionary<Pdf417Level, string>()
        {
            { Pdf417Level.Ecc0, "Ecc0" },
            { Pdf417Level.Ecc1, "Ecc1" },
            { Pdf417Level.Ecc2, "Ecc2" },
            { Pdf417Level.Ecc3, "Ecc3" },
            { Pdf417Level.Ecc4, "Ecc4" },
            { Pdf417Level.Ecc5, "Ecc5" },
            { Pdf417Level.Ecc6, "Ecc6" },
            { Pdf417Level.Ecc7, "Ecc7" },
            { Pdf417Level.Ecc8, "Ecc8" },
        };

        private static readonly IReadOnlyDictionary<QRCodeModel, string> PrinterQRCodeModelDictionary = new Dictionary<QRCodeModel, string>()
        {
            { QRCodeModel.Model1, "Model1" },
            { QRCodeModel.Model2, "Model2" },
        };

        private static readonly IReadOnlyDictionary<QRCodeLevel, string> PrinterQRCodeLevelDictionary = new Dictionary<QRCodeLevel, string>()
        {
            { QRCodeLevel.L, "L" },
            { QRCodeLevel.M, "M" },
            { QRCodeLevel.Q, "Q" },
            { QRCodeLevel.H, "H" },
        };

        private static readonly IReadOnlyDictionary<StarMicronics.StarIO10.StarXpandCommand.Buzzer.Channel, string> BuzzerChannelDictionary = new Dictionary<StarMicronics.StarIO10.StarXpandCommand.Buzzer.Channel, string>()
        {
            { StarMicronics.StarIO10.StarXpandCommand.Buzzer.Channel.No1, "No1" },
            { StarMicronics.StarIO10.StarXpandCommand.Buzzer.Channel.No2, "No2" },
        };

        private static readonly IReadOnlyDictionary<StarMicronics.StarIO10.StarXpandCommand.Drawer.Channel, string> DrawerChannelDictionary = new Dictionary<StarMicronics.StarIO10.StarXpandCommand.Drawer.Channel, string>()
        {
            { StarMicronics.StarIO10.StarXpandCommand.Drawer.Channel.No1, "No1" },
            { StarMicronics.StarIO10.StarXpandCommand.Drawer.Channel.No2, "No2" }
        };

        private static readonly IReadOnlyDictionary<SoundStorageArea, string> MelodySpeakerSoundStorageAreaDictionary = new Dictionary<SoundStorageArea, string>()
        {
            { SoundStorageArea.Area1, "Area1" },
            { SoundStorageArea.Area2, "Area2" },
        };

        private static readonly IReadOnlyDictionary<Contrast, string> DisplayContrastDictionary = new Dictionary<Contrast, string>()
        {
            { Contrast.Plus3, "Plus3" },
            { Contrast.Plus2, "Plus2" },
            { Contrast.Plus1, "Plus1" },
            { Contrast.Default, "Default" },
            { Contrast.Minus1, "Minus1" },
            { Contrast.Minus2, "Minus2" },
            { Contrast.Minus3, "Minus3" }
        };

        private static readonly IReadOnlyDictionary<CursorState, string> DisplayCursorStateDictionary = new Dictionary<CursorState, string>()
        {
            { CursorState.On, "On" },
            { CursorState.Blink, "Blink" },
            { CursorState.Off, "Off" }
        };

  