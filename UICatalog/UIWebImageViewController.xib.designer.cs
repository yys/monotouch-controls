// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace escoz {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("UIWebImageViewController")]
	public partial class UIWebImageViewController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private UIWebImageView __mt_uiWebImageView;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Export("onNextImage:")]
		partial void onNextImage (MonoTouch.UIKit.UIButton sender);

		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("uiWebImageView")]
		private UIWebImageView uiWebImageView {
			get {
				this.__mt_uiWebImageView = ((UIWebImageView)(this.GetNativeField("uiWebImageView")));
				return this.__mt_uiWebImageView;
			}
			set {
				this.__mt_uiWebImageView = value;
				this.SetNativeField("uiWebImageView", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIImageView or subclass
	[MonoTouch.Foundation.Register("UIWebImageView")]
	public partial class UIWebImageView {
	}
}
