package com.stario10module

import androidx.annotation.Nullable
import com.facebook.react.bridge.*
import com.facebook.react.modules.core.DeviceEventManagerModule
import com.starmicronics.stario10.*


class StarDeviceDiscoveryManagerWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "StarDeviceDiscoveryManagerWrapper"
    }

    @ReactMethod
    fun init(interfaceTypes: ReadableArray, promise: Promise) {
        val typeList = mutableListOf<InterfaceType>()

        for(type in StarIO10ValueConverter.toList<String>(interfaceTypes)) {
            typeList.add(StarIO10ValueConverter.toInterfaceType(type))
        }

        try {
            val manager = StarDeviceDiscoveryManagerFactory.create(typeList, reactApplicationContext)
            val identifier = InstanceManager.set(manager)

            promise.resolve(identifier)
        }
        catch (e: StarIO10Exception) {
            val exceptionIdentifier = InstanceManager.set(e)
            promise.reject(exceptionIdentifier, e)
        }
    }

    @ReactMethod
    fun dispose(identifier: String, promise: Promise) {
        InstanceManager.remove(identifier)
        promise.resolve(0)
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
    fun startDiscovery(identifier: String, discoveryTime: Int, promise: Promise) {
        val manager = InstanceManager.get(identifier)

        if (manager is StarDeviceDiscoveryManager) {
            manager.discoveryTime = discoveryTime

            try {
                manager.callback = object: StarDeviceDiscoveryManager.Callback {
                    override fun onPrinterFound(printer: StarPrinter) {
                        val params = Arguments.createMap()
                        params.putString(EventParameter.KEY_IDENTIFIER, identifier)
                        params.putString(EventPara