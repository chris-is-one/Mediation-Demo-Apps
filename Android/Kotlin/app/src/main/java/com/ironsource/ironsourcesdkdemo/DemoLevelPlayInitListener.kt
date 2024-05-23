package com.ironsource.ironsourcesdkdemo

import com.unity3d.mediation.LevelPlayConfiguration
import com.unity3d.mediation.LevelPlayInitError
import com.unity3d.mediation.LevelPlayInitListener

class DemoLevelPlayInitListener(private val listener: DemoActivityListener)
    : LevelPlayInitListener {
    private val TAG = DemoInitializationListener::class.java.name

    override fun onInitFailed(error: LevelPlayInitError) {
        DemoActivity.logCallbackName(TAG, "error = $error")
    }

    override fun onInitSuccess(configuration: LevelPlayConfiguration) {
        DemoActivity.logCallbackName(TAG, "config = $configuration")
        listener.setEnablementForButton(DemoButtonIdentifiers.LOAD_INTERSTITIAL_BUTTON_IDENTIFIER, true)
        listener.setEnablementForButton(DemoButtonIdentifiers.LOAD_BANNER_BUTTON_IDENTIFIER, true)
    }
}