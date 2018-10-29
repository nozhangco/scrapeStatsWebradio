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
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_COVER_OPENED, params)
                }

                override fun onCoverClosed() {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_COVER_CLOSED, params)
                }

                override fun onCommunicationError(exception: StarIO10Exception) {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    val exceptionIdentifier = InstanceManager.set(exception)
                    params.putString(EventParameter.KEY_ERROR_IDENTIFIER, exceptionIdentifier)

                    sendEvent(EventParameter.NAME_PRINTER_DELEGATE_COMMUNICATION_ERROR, params)
                }
            }

            promise.resolve(0)
        }
        else {
            promise.reject(StarIO10Exception("Identifier error"))
        }
    }

    @ReactMethod
    fun activateDrawerDelegate(identifier: String, promise: Promise) {
        val printer = InstanceManager.get(identifier)

        if (printer is StarPrinter) {
            printer.drawerDelegate = object : DrawerDelegate() {
                override fun onOpenCloseSignalSwitched(signalState: Boolean) {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)
                    params.putBoolean(EventParameter.KEY_DRAWER_OPEN_CLOSE_SIGNAL_STATE, signalState)

                    sendEvent(EventParameter.NAME_DRAWER_DELEGATE_OPEN_CLOSE_SIGNAL_SWITCHED, params)
                }

                override fun onCommunicationError(exception: StarIO10Exception) {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    val exceptionIdentifier = InstanceManager.set(exception)
                    params.putString(EventParameter.KEY_ERROR_IDENTIFIER, exceptionIdentifier)

                    sendEvent(EventParameter.NAME_DRAWER_DELEGATE_COMMUNICATION_ERROR, params)
                }
            }

            promise.resolve(0)
        }
        else {
            promise.reject(StarIO10Exception("Identifier error"))
        }
    }

    @ReactMethod
    fun activateInputDeviceDelegate(identifier: String, promise: Promise) {
        val printer = InstanceManager.get(identifier)

        if (printer is StarPrinter) {
            printer.inputDeviceDelegate = object : InputDeviceDelegate() {
                override fun onConnected() {
                    val params = Arguments.createMap()
                    params.putString(EventParameter.KEY_IDENTIFIER, identifier)

                    sendEvent(EventParameter.NAME_INPUT_DEVICE_DELEGATE_CONNECTED, params)
                }

                override fun onDisconnected() {
            