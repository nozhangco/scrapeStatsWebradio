
package com.stario10module

import android.content.Context
import android.graphics.Bitmap
import android.graphics.BitmapFactory
import android.net.Uri
import android.util.Base64
import com.facebook.common.references.CloseableReference
import com.facebook.datasource.DataSource
import com.facebook.drawee.backends.pipeline.Fresco
import com.facebook.imagepipeline.datasource.BaseBitmapDataSubscriber
import com.facebook.imagepipeline.image.CloseableImage
import com.facebook.imagepipeline.request.ImageRequest
import com.facebook.react.bridge.Arguments
import com.facebook.react.bridge.ReadableArray
import com.facebook.react.bridge.WritableArray
import com.facebook.react.bridge.WritableMap
import com.starmicronics.stario10.InterfaceType
import com.starmicronics.stario10.StarIO10ArgumentException
import com.starmicronics.stario10.StarPrinterEmulation
import com.starmicronics.stario10.StarPrinterModel
import com.starmicronics.stario10.starxpandcommand.MagnificationParameter
import com.starmicronics.stario10.starxpandcommand.display.Contrast
import com.starmicronics.stario10.starxpandcommand.display.CursorState
import com.starmicronics.stario10.starxpandcommand.melodyspeaker.DriveOneTimeSoundParameter
import com.starmicronics.stario10.starxpandcommand.melodyspeaker.DriveRegisteredSoundParameter
import com.starmicronics.stario10.starxpandcommand.melodyspeaker.SoundStorageArea
import com.starmicronics.stario10.starxpandcommand.presenter.ModeParameter
import com.starmicronics.stario10.starxpandcommand.printer.*
import okhttp3.OkHttpClient
import okhttp3.Request
import java.io.InputStream
import java.lang.Thread.sleep
import java.util.*
import java.util.concurrent.Executors


class StarIO10ValueConverter {
    companion object {

        private val interfaceTypeMap = mapOf(
            "Bluetooth" to InterfaceType.Bluetooth,
            "BluetoothLE" to InterfaceType.BluetoothLE,
            "Lan" to InterfaceType.Lan,
            "Usb" to InterfaceType.Usb
        )

        fun toInterfaceType(value: String) : InterfaceType {
            return interfaceTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        fun toString(value: InterfaceType) : String {
            var result: String? = null

            for(item in interfaceTypeMap) {
                if(item.value == value) {
                    result = item.key
                    break
                }
            }
            return result ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val printerModelMap = mapOf(
            "Unknown" to StarPrinterModel.Unknown,
            "TSP650II" to StarPrinterModel.TSP650II,
            "TSP700II" to StarPrinterModel.TSP700II,
            "TSP800II" to StarPrinterModel.TSP800II,
            "TSP100IIU_Plus" to StarPrinterModel.TSP100IIU_Plus,
            "TSP100IIIW" to StarPrinterModel.TSP100IIIW,
            "TSP100IIILAN" to StarPrinterModel.TSP100IIILAN,
            "TSP100IIIBI" to StarPrinterModel.TSP100IIIBI,
            "TSP100IIIU" to StarPrinterModel.TSP100IIIU,
            "TSP100IV" to StarPrinterModel.TSP100IV, 
            "mPOP" to StarPrinterModel.mPOP,
            "mC_Print2" to StarPrinterModel.mC_Print2,
            "mC_Print3" to StarPrinterModel.mC_Print3,
            "SM_S210i" to StarPrinterModel.SM_S210i,
            "SM_S230i" to StarPrinterModel.SM_S230i,
            "SM_T300" to StarPrinterModel.SM_T300,
            "SM_T300i" to StarPrinterModel.SM_T300i,
            "SM_T400i" to StarPrinterModel.SM_T400i,
            "SM_L200" to StarPrinterModel.SM_L200,
            "SM_L300" to StarPrinterModel.SM_L300,
            "BSC10" to StarPrinterModel.BSC10,
            "TSP043" to StarPrinterModel.TSP043,
            "SP700" to StarPrinterModel.SP700,
            "TUP500" to StarPrinterModel.TUP500,
            "SK1_2xx" to StarPrinterModel.SK1_2xx,
            "SK1_3xx" to StarPrinterModel.SK1_3xx
        )

        fun toString(value: StarPrinterModel) : String {
            var result = "Unknown"

            for(item in printerModelMap) {
                if(item.value == value) {
                    result = item.key
                    break
                }
            }

            return result
        }

        private val printerEmulationMap = mapOf(
            "Unknown" to StarPrinterEmulation.Unknown,
            "StarLine" to StarPrinterEmulation.StarLine,
            "StarDot" to StarPrinterEmulation.StarDot,
            "StarGraphic" to StarPrinterEmulation.StarGraphic,
            "StarPRNT" to StarPrinterEmulation.StarPRNT,
            "EscPos" to StarPrinterEmulation.EscPos,
            "EscPosMobile" to StarPrinterEmulation.EscPosMobile
        )

        fun toString(value: StarPrinterEmulation) : String {
            var result = "Unknown"

            for(item in printerEmulationMap) {
                if(item.value == value) {
                    result = item.key
                    break
                }
            }
            return result
        }

        private val bezelLedTypeMap = mapOf(
            "Holding" to com.starmicronics.stario10.starxpandcommand.bezel.LedType.Holding,
            "Error" to com.starmicronics.stario10.starxpandcommand.bezel.LedType.Error,
            "Idle" to com.starmicronics.stario10.starxpandcommand.bezel.LedType.Idle
        )

        fun toBezelLedType(value: String) : com.starmicronics.stario10.starxpandcommand.bezel.LedType {
            return bezelLedTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val presenterLedTypeMap = mapOf(
            "Holding" to com.starmicronics.stario10.starxpandcommand.presenter.LedType.Holding,
            "Error" to com.starmicronics.stario10.starxpandcommand.presenter.LedType.Error,
            "Idle" to com.starmicronics.stario10.starxpandcommand.presenter.LedType.Idle
        )

        fun toPresenterLedType(value: String) : com.starmicronics.stario10.starxpandcommand.presenter.LedType {
            return presenterLedTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val printerBlackMarkPositionMap = mapOf(
            "Front" to BlackMarkPosition.Front,
            "Back" to BlackMarkPosition.Back
        )

        fun toPrinterBlackMarkPosition(value: String) : BlackMarkPosition {
            return printerBlackMarkPositionMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val cutTypeMap = mapOf(
            "Full" to CutType.Full,
            "Partial" to CutType.Partial,
            "FullDirect" to CutType.FullDirect,
            "PartialDirect" to CutType.PartialDirect
        )

        fun toPrinterCutType(value: String) : CutType {
            return cutTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val alignmentMap = mapOf(
            "Left" to Alignment.Left,
            "Center" to Alignment.Center,
            "Right" to Alignment.Right
        )

        fun toPrinterAlignment(value: String) : Alignment {
            return alignmentMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val printerCharacterEncodingTypeMap = mapOf(
            "Japanese" to com.starmicronics.stario10.starxpandcommand.printer.CharacterEncodingType.Japanese,
            "SimplifiedChinese" to com.starmicronics.stario10.starxpandcommand.printer.CharacterEncodingType.SimplifiedChinese,
            "TraditionalChinese" to com.starmicronics.stario10.starxpandcommand.printer.CharacterEncodingType.TraditionalChinese,
            "Korean" to com.starmicronics.stario10.starxpandcommand.printer.CharacterEncodingType.Korean,
            "CodePage" to com.starmicronics.stario10.starxpandcommand.printer.CharacterEncodingType.CodePage
        )

        fun toPrinterCharacterEncodingType(value: String) : com.starmicronics.stario10.starxpandcommand.printer.CharacterEncodingType {
            return printerCharacterEncodingTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val cjkCharacterTypeMap = mapOf(
            "Japanese" to CjkCharacterType.Japanese,
            "SimplifiedChinese" to CjkCharacterType.SimplifiedChinese,
            "TraditionalChinese" to CjkCharacterType.TraditionalChinese,
            "Korean" to CjkCharacterType.Korean
        )

        fun toPrinterCjkCharacterType(value: String) : CjkCharacterType {
            return cjkCharacterTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val fontTypeMap = mapOf(
            "A" to FontType.A,
            "B" to FontType.B
        )

        fun toPrinterFontType(value: String) : FontType {
            return fontTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val internationalCharacterTypeMap = mapOf(
            "Denmark" to InternationalCharacterType.Denmark,
            "Denmark2" to InternationalCharacterType.Denmark2,
            "France" to InternationalCharacterType.France,
            "Germany" to InternationalCharacterType.Germany,
            "Ireland" to InternationalCharacterType.Ireland,
            "Italy" to InternationalCharacterType.Italy,
            "Japan" to InternationalCharacterType.Japan,
            "Korea" to InternationalCharacterType.Korea,
            "LatinAmerica" to InternationalCharacterType.LatinAmerica,
            "Legal" to InternationalCharacterType.Legal,
            "Norway" to InternationalCharacterType.Norway,
            "Spain" to InternationalCharacterType.Spain,
            "Spain2" to InternationalCharacterType.Spain2,
            "Sweden" to InternationalCharacterType.Sweden,
            "UK" to InternationalCharacterType.UK,
            "Usa" to InternationalCharacterType.Usa,
            "Slovenia" to InternationalCharacterType.Slovenia,
            "Croatia" to InternationalCharacterType.Croatia,
            "China" to InternationalCharacterType.China,
            "Vietnam" to InternationalCharacterType.Vietnam,
            "Arabic" to InternationalCharacterType.Arabic
        )

        fun toPrinterInternationalType(value: String) : InternationalCharacterType {
            return internationalCharacterTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val barcodeSymbologyTypeMap = mapOf(
            "Code128" to BarcodeSymbology.Code128,
            "Code39" to BarcodeSymbology.Code39,
            "Code93" to BarcodeSymbology.Code93,
            "Ean13" to BarcodeSymbology.Ean13,
            "Ean8" to BarcodeSymbology.Ean8,
            "UpcA" to BarcodeSymbology.UpcA,
            "UpcE" to BarcodeSymbology.UpcE,
            "Itf" to BarcodeSymbology.Itf,
            "Jan13" to BarcodeSymbology.Jan13,
            "Jan8" to BarcodeSymbology.Jan8,
            "NW7" to BarcodeSymbology.NW7
        )

        fun toPrinterBarcodeSymbology(value: String) : BarcodeSymbology {
            return barcodeSymbologyTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val barcodeBarRatioLevelTypeMap = mapOf(
            "Level0" to BarcodeBarRatioLevel.Level0,
            "LevelMinus1" to BarcodeBarRatioLevel.LevelMinus1,
            "LevelPlus1" to BarcodeBarRatioLevel.LevelPlus1
        )

        fun toPrinterBarcodeBarRatioLevel(value: String) : BarcodeBarRatioLevel {
            return barcodeBarRatioLevelTypeMap[value] ?: throw StarIO10ArgumentException("Undefined parameter '$value'")
        }

        private val printerPdf417LevelMap = mapOf(
            "Ecc0" to Pdf417Level.Ecc0,
            "Ecc1" to Pdf417Level.Ecc1,
            "Ecc2" to Pdf417Level.Ecc2,
            "Ecc3" to Pdf417Level.Ecc3,
            "Ecc4" to Pdf417Level.Ecc4,
            "Ecc5" to Pdf417Level.Ecc5,
            "Ecc6" to Pdf417Level.Ecc6,
            "Ecc7" to Pdf417Level.Ecc7,
            "Ecc8" to Pdf417Level.Ecc8
        )

        fun toPrinterPdf417Level(value: String) : Pdf417Level {