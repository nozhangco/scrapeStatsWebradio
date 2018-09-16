package com.stario10module

import com.facebook.react.bridge.*
import com.starmicronics.stario10.starxpandcommand.MelodySpeakerBuilder
import com.starmicronics.stario10.StarIO10ArgumentException

class MelodySpeakerBuilderWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "MelodySpeakerBuilderWrapper"
    }

    @ReactMethod
    fun init(promise: Promise) {
        val builder = MelodySpeakerBuilder()
        val identifier = InstanceManager.set(builder)

        promise.resolve(identifier)
    }

    @ReactMethod
    fun dispose(identifier: String, promise: Promise) {
        InstanceManager.remove(identifier)
        promise.resolve(0)
    }

    @ReactMethod
    fun act