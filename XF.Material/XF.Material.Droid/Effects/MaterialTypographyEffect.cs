﻿using Xamarin.Forms;
using XF.Material.Droid.Effects;

[assembly: ResolutionGroupName("Material")]
[assembly: ExportEffect(typeof(MaterialTypographyEffect), "TypographyEffect")]
namespace XF.Material.Droid.Effects
{
    public class MaterialTypographyEffect : BaseMaterialEffect<XF.Material.Effects.MaterialTypographyEffect>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            if (!Material.IsLollipop)
            {
                return;
            }

            if(this.Control is Android.Widget.TextView textView)
            {
                textView.LetterSpacing = (float)this.MaterialEffect.LetterSpacing;
            }
        }
    }
}