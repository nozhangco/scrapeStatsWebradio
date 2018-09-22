package com.stario10module

import com.facebook.react.bridge.*
import com.starmicronics.stario10.starxpandcommand.BezelSettingBuilder
import com.starmicronics.stario10.starxpandcommand.PreSettingBuilder
import com.starmicronics.stario10.starxpandcommand.PresenterSettingBuilder

class PreSettingBuilderWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "PreSettingBuilderWrapper"
    }

    @ReactMethod
    fun init(promise: Promise) {
        val builder = PreSettingBuilder()
        val identifier = InstanceManager.set(builder)

        promise.resolve(identifier)
    }

    @ReactMethod
    fun dispose(identifier: String, promise: Promise) {
        InstanceManager.remove(identifier)
        promise.resolve(0)
    }

    @ReactMethod
    fun addPresenterSetting(identifier