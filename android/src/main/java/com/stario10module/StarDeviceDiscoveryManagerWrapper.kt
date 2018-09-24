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
            typeList.add(StarIO10ValueCo