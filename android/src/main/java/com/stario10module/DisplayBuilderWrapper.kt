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
    fun init(promise: Promise) {
        val builder = DisplayBuilder()
        val identifier = InstanceManager.set(builder)

        promise.resolve(identifier)
    }

    @ReactMethod
    fun dispose(identifier: String, promise: Promise) {
        InstanceManager.remove(identifier)
        promise.resolve(0)
    }

    @ReactMethod
    fun styleInternationalCharacter(identifier: String, type: String, promise: Promise) {
        val builder = InstanceManager.get(identifier)

        if (builder is DisplayBuilder) {
            builder.styleInternationalCharacter(StarIO10ValueConverter.toDisplayInternationalCharacterType(type))
            promise.resolve(0)
        }
        else {
            promise.reject(ReactNoCrashSoftEx