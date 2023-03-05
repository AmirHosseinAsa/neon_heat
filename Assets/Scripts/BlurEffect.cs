using UnityEngine;

public class BlurEffect{
    float startTime = -100f;
    float duration = 0.7f;
    bool onOff = false;
    UnityStandardAssets.ImageEffects.MotionBlur blurScript;

	// Update is called once per frame
	public void Update () {
        if (blurScript == null) {
            blurScript = Info.getBlurEffects();
            return;
        }

        if(startTime + duration > Time.time) {
            onOff = true;
        } else {
            onOff = false;
        }

        blurScript.enabled = onOff;

        blurScript.blurAmount = Helper.Remap((startTime + duration - Time.time), 0, duration, 0, 1f);
    }

    public void Quake() {
        startTime = Time.time;
    }
}
