package com.ironsource.ironsourcesdkdemo

import com.unity3d.mediation.LevelPlayAdError
import com.unity3d.mediation.LevelPlayAdInfo
import com.unity3d.mediation.banner.LevelPlayBannerAdViewListener
import android.view.View
import com.ironsource.ironsourcesdkdemo.DemoActivity.Companion.logCallbackName



class DemoLevelPlayBannerAdListener (private val listener: DemoActivityListener)
    : LevelPlayBannerAdViewListener {
    private val TAG = DemoBannerAdListener::class.java.name

    override fun onAdLoadFailed(error: LevelPlayAdError) {
        logCallbackName(TAG, "error = $error")
    }

    override fun onAdLoaded(adInfo: LevelPlayAdInfo) {
        logCallbackName(TAG, "adInfo = $adInfo")
        listener.setBannerViewVisibility(View.VISIBLE)
        listener.setEnablementForButton(DemoButtonIdentifiers.LOAD_BANNER_BUTTON_IDENTIFIER, false)
        listener.setEnablementForButton(DemoButtonIdentifiers.DESTROY_BANNER_BUTTON_IDENTIFIER, true)
    }

    override fun onAdClicked(adInfo: LevelPlayAdInfo) {
        // Not necessary as the body of the inheriting interface is null
        // However, let's leave it for just in case
        super.onAdClicked(adInfo)
        logCallbackName(TAG, "adInfo = $adInfo")
    }

    override fun onAdCollapsed(adInfo: LevelPlayAdInfo) {
        super.onAdCollapsed(adInfo)
        logCallbackName(TAG, "adInfo = $adInfo")
    }

    override fun onAdDisplayFailed(adInfo: LevelPlayAdInfo, error: LevelPlayAdError) {
        super.onAdDisplayFailed(adInfo, error)
        logCallbackName(TAG, "adInfo = $adInfo\nerror = $error")
    }

    override fun onAdDisplayed(adInfo: LevelPlayAdInfo) {
        super.onAdDisplayed(adInfo)
        logCallbackName(TAG, "adInfo = $adInfo")
    }

    override fun onAdExpanded(adInfo: LevelPlayAdInfo) {
        super.onAdExpanded(adInfo)
        logCallbackName(TAG, "adInfo = $adInfo")
    }

    override fun onAdLeftApplication(adInfo: LevelPlayAdInfo) {
        super.onAdLeftApplication(adInfo)
        logCallbackName(TAG, "adInfo = $adInfo")
    }
}
