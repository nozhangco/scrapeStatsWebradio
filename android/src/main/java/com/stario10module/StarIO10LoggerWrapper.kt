package com.stario10module

import com.facebook.react.bridge.Promise
import com.facebook.react.bridge.ReactApplicationContext
import com.facebook.react.bridge.ReactContextBaseJavaModule
import com.facebook.react.bridge.ReactMethod
import com.starmicronics.stario10.StarIO10Logger
import com.starmicronics.stario10.internal.InternalInterface

class StarIO10LoggerWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "StarIO10LoggerWrapper"
    }

    @ReactMethod
    fun 