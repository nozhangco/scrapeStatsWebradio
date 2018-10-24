package com.stario10module

import androidx.annotation.Nullable
import com.facebook.react.bridge.*
import com.facebook.react.modules.core.DeviceEventManagerModule
import com.starmicronics.stario10.*
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.SupervisorJob
import kotlinx.coroutines.launch


class StarPrinterWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "StarPrinterWrapper"
    }

    @ReactMethod
    fun init(promise: Promise) {
        val printer = StarPrinter(StarConnectionSettings(InterfaceType.Unknown), reactApplicationContext)
        val identifier = InstanceManager.set(printer)

        promise.resolve(identifier)
    }

    @ReactMethod
    fun addListener(eventName: String) {
        // Set up any upstream listeners or background tasks as necessary
    }

    @ReactMethod
    fun removeListeners(count: Int) {
        // Remove upstream listeners, stop unnecessary background tasks
    }

    @ReactMethod
    fun activatePrinterDelegate(identifier: String, promise: Promise) {
        val printer = InstanceManager.get(identifier)

        if (printer is StarPrinter) {
            printer.printerDelegate = object : PrinterDelegate() {
                override fun onReady() {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_READY, params)
                }

                override fun onError() {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_ERROR, params)
                }

                override fun onPaperReady() {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_PAPER_READY, params)
                }

                override fun onPaperNearEmpty() {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_PAPER_NEAR_EMPTY, params)
                }

                override fun onPaperEmpty() {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_PAPER_EMPTY, params)
                }

                override fun onCoverOpened() {
     