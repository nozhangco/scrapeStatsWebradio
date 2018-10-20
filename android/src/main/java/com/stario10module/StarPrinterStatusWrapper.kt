package com.stario10module

import com.facebook.react.bridge.*
import com.starmicronics.stario10.StarIO10Exception
import com.starmicronics.stario10.StarPrinter
import com.starmicronics.stario10.StarPrinterStatus


class StarPrinterStatusWrapper internal constructor(context: ReactApplicationContext) : ReactContextBaseJavaModule(context) {
    override fun getName(): String {
        return "StarPrinterStatusWrapper"
    }

    @ReactMethod
    fun getHasError(identifier: String, promise: Promise) {
        val status = InstanceManager.get(identifier)

        if (status is StarPrinterStatus) {
            promise.resolve(status.hasError)
        }
        else {
            promise.reject(ReactNoCrashSoftException("Not found $identifier identifier"))
        }
    }

    @ReactMethod
    fun getPaperEmpty(identifier: String, promise: Promise) {
        val status = InstanceManager.get(identifier)

        if (status is StarPrinterStatus) {
            promise.resolve(status.paperEmpty)
        }
        else {
            promise.r