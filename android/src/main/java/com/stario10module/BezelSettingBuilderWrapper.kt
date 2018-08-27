package com.stario10module

import com.facebook.react.bridge.*
import com.starmicronics.stario10.starxpandcommand.BezelSettingBuilder

class BezelSettingBuilderWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "BezelSettingBuilderWrapper"
    }

    @ReactMethod
    fun init(promise: Promise) {
        val builder = BezelSettingBuilder()
        val identifier = InstanceManager.set(builder)

        promise.resolve(identifier)
    }

    @ReactMethod
    fun dispose(identifier: String, promise: Promise) {
        InstanceManager.remove(identifier)
        promise.resolve(0)
    }

    @ReactMethod
    fun settingAutomaticPageLength(identifier: String, enabled: Boolean, promise: Promise) {
        val builder = InstanceManager.get(identifier)

        if (builder is BezelSettingBuilder) {
            builder.settingAutomaticPageLength(enabled)
            promise.resolve(0)
        }
        else {
            promise.reject(ReactNoCrashSoftExcep