package com.stario10module

import com.facebook.react.bridge.*
import com.starmicronics.stario10.StarIO10ArgumentException
import com.starmicronics.stario10.starxpandcommand.DisplayBuilder
import com.starmicronics.stario10.starxpandcommand.PrinterBuilder

class DisplayBuilderWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "DisplayBuilderWrapper"
    }

    @ReactMethod
    fun init(promise: Pro