using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ShareKit
{
    [BaseType (typeof (NSObject))]
    interface DefaultSHKConfigurator {
        [Export ("appURL")]
        string AppURL ();
        
        [Export ("defaultFavoriteURLSharers")]
        string[] DefaultFavoriteURLSharers ();
        
        [Export ("defaultFavoriteImageSharers")]
        string[] DefaultFavoriteImageSharers ();
        
        [Export ("defaultFavoriteTextSharers")]
        string[] DefaultFavoriteTextSharers ();
        
        [Export ("defaultFavoriteFileSharers")]
        string[] DefaultFavoriteFileSharers ();
        
        [Export ("vkontakteAppId")]
        string VkontakteAppId ();
        
        [Export ("facebookAppId")]
        string FacebookAppId ();
        
        [Export ("facebookLocalAppId")]
        string FacebookLocalAppId ();
        
        [Export ("facebookWritePermissions")]
        string[] FacebookWritePermissions ();
        
        [Export ("facebookReadPermissions")]
        string[] FacebookReadPermissions ();
        
        [Export ("forcePreIOS6FacebookPosting")]
        NSNumber ForcePreIOS6FacebookPosting ();
        
        [Export ("readItLaterKey")]
        string ReadItLaterKey ();
        
        [Export ("diigoKey")]
        string DiigoKey ();
        
        [Export ("forcePreIOS5TwitterAccess")]
        NSNumber ForcePreIOS5TwitterAccess ();
        
        [Export ("twitterConsumerKey")]
        string TwitterConsumerKey ();
        
        [Export ("twitterSecret")]
        string TwitterSecret ();
        
        [Export ("twitterCallbackUrl")]
        string TwitterCallbackUrl ();
        
        [Export ("twitterUseXAuth")]
        NSNumber TwitterUseXAuth ();
        
        [Export ("twitterUsername")]
        string TwitterUsername ();
        
        [Export ("tumblrConsumerKey")]
        string TumblrConsumerKey ();
        
        [Export ("tumblrSecret")]
        string TumblrSecret ();
        
        [Export ("tumblrCallbackUrl")]
        string TumblrCallbackUrl ();
        
        [Export ("tumblrUseXAuth")]
        NSNumber TumblrUseXAuth ();
        
        [Export ("evernoteHost")]
        string EvernoteHost ();
        
        [Export ("evernoteConsumerKey")]
        string EvernoteConsumerKey ();
        
        [Export ("evernoteSecret")]
        string EvernoteSecret ();
        
        [Export ("flickrConsumerKey")]
        string FlickrConsumerKey ();
        
        [Export ("flickrSecretKey")]
        string FlickrSecretKey ();
        
        [Export ("flickrCallbackUrl")]
        string FlickrCallbackUrl ();
        
        [Export ("bitLyLogin")]
        string BitLyLogin ();
        
        [Export ("bitLyKey")]
        string BitLyKey ();
        
        [Export ("linkedInConsumerKey")]
        string LinkedInConsumerKey ();
        
        [Export ("linkedInSecret")]
        string LinkedInSecret ();
        
        [Export ("linkedInCallbackUrl")]
        string LinkedInCallbackUrl ();
        
        [Export ("readabilityConsumerKey")]
        string ReadabilityConsumerKey ();
        
        [Export ("readabilitySecret")]
        string ReadabilitySecret ();
        
        [Export ("readabilityUseXAuth")]
        NSNumber ReadabilityUseXAuth ();
        
        [Export ("foursquareV2ClientId")]
        string FoursquareV2ClientId ();
        
        [Export ("foursquareV2RedirectURI")]
        string FoursquareV2RedirectURI ();
        
        [Export ("shareMenuAlphabeticalOrder")]
        NSNumber ShareMenuAlphabeticalOrder ();
        
        [Export ("barStyle")]
        string BarStyle ();
        
        [Export ("barTintForView:")]
        UIColor BarTintForView (UIViewController vc);
        
        [Export ("formFontColor")]
        UIColor FormFontColor ();
        
        [Export ("formBackgroundColor")]
        UIColor FormBackgroundColor ();
        
        [Export ("modalPresentationStyleForController:")]
        string ModalPresentationStyleForController (UIViewController controller);
        
        [Export ("modalTransitionStyleForController:")]
        string ModalTransitionStyleForController (UIViewController controller);
        
        [Export ("isUsingCocoaPods")]
        NSNumber IsUsingCocoaPods ();
        
        [Export ("maxFavCount")]
        NSNumber MaxFavCount ();
        
        [Export ("autoOrderFavoriteSharers")]
        NSNumber AutoOrderFavoriteSharers ();
        
        [Export ("favsPrefixKey")]
        string FavsPrefixKey ();
        
        [Export ("authPrefix")]
        string AuthPrefix ();
        
        [Export ("sharersPlistName")]
        string SharersPlistName ();
        
        [Export ("showActionSheetMoreButton")]
        NSNumber ShowActionSheetMoreButton ();
        
        [Export ("allowOffline")]
        NSNumber AllowOffline ();
        
        [Export ("allowAutoShare")]
        NSNumber AllowAutoShare ();
        
        [Export ("SHKActionSheetSubclass")]
        Class SHKActionSheetSubclass ();
        
        [Export ("SHKShareMenuSubclass")]
        Class SHKShareMenuSubclass ();
        
        [Export ("SHKShareMenuCellSubclass")]
        Class SHKShareMenuCellSubclass ();
        
        [Export ("SHKFormControllerSubclass")]
        Class SHKFormControllerSubclass ();
        
        [Export ("printOutputType")]
        NSNumber PrintOutputType ();
        
        [Export ("mailToRecipients")]
        string[] MailToRecipients ();
        
        [Export ("isMailHTML")]
        NSNumber IsMailHTML ();
        
        [Export ("mailJPGQuality")]
        NSNumber MailJPGQuality ();
        
        [Export ("sharedWithSignature")]
        NSNumber SharedWithSignature ();
        
        [Export ("facebookURLSharePictureURI")]
        string FacebookURLSharePictureURI ();
        
        [Export ("facebookURLShareDescription")]
        string FacebookURLShareDescription ();
        
        [Export ("textMessageToRecipients")]
        string[] TextMessageToRecipients ();
        
        [Export ("popOverSourceRect")]
        string PopOverSourceRect ();
        
    }

    [BaseType (typeof (NSObject))]
    interface SHK {
        [Export ("pendingView")]
        UIViewController PendingView { get; set;  }
        
        [Export ("isDismissingView")]
        bool IsDismissingView { get; set;  }
        
        [Export ("offlineQueue")]
        NSOperationQueue OfflineQueue { get; set;  }
        
        [Export ("currentHelper")]
        SHK CurrentHelper ();
        
        [Static]
        [Export ("sharersDictionary")]
        NSDictionary SharersDictionary ();

        [Static]
        [Export ("setRootViewController:")]
        void SetRootViewController (UIViewController vc);
        
        [Export ("showViewController:")]
        void ShowViewController (UIViewController vc);
        
        [Export ("showStandaloneViewController:")]
        void ShowStandaloneViewController (UIViewController vc);
        
        [Export ("rootViewForUIDisplay")]
        UIViewController RootViewForUIDisplay ();
        
        [Export ("hideCurrentViewControllerAnimated:")]
        void HideCurrentViewControllerAnimated (bool animated);
        
        [Export ("viewWasDismissed")]
        void ViewWasDismissed ();
        
        [Static]
        [Export ("barStyle")]
        UIBarStyle BarStyle ();
        
        [Static]
        [Export ("modalPresentationStyleForController:")]
        UIModalPresentationStyle ModalPresentationStyleForController (UIViewController controller);
        
        [Static]
        [Export ("modalTransitionStyleForController:")]
        UIModalTransitionStyle ModalTransitionStyleForController (UIViewController controller);
        
        [Export ("favoriteSharersForType:")]
        string[] FavoriteSharers (SHKShareType type);
        
        [Static]
        [Export ("pushOnFavorites:forType:")]
        void PushOnFavorites (string className, SHKShareType type);
        
        [Static]
        [Export ("setFavorites:forType:")]
        void SetFavorites (string[] favs, SHKShareType type);
        
        [Export ("getAuthValueForKey:forSharer:")]
        string GetAuthValue (string key, string sharerId);
        
        [Static]
        [Export ("setAuthValue:forKey:forSharer:")]
        void SetAuthValue (string value, string key, string sharerId);
        
        [Static]
        [Export ("removeAuthValueForKey:forSharer:")]
        void RemoveAuthValue (string key, string sharerId);
        
        [Static]
        [Export ("logoutOfAll")]
        void LogoutOfAll ();
        
        [Static]
        [Export ("logoutOfService:")]
        void LogoutOfService (string sharerId);
        
        [Export ("offlineQueuePath")]
        string OfflineQueuePath ();
        
        [Static]
        [Export ("offlineQueueListPath")]
        string OfflineQueueListPath ();
        
        [Static]
        [Export ("getOfflineQueueList")]
        NSMutableArray GetOfflineQueueList ();
        
        [Static]
        [Export ("saveOfflineQueueList:")]
        void SaveOfflineQueueList (NSMutableArray queueList);
        
        [Static]
        [Export ("addToOfflineQueue:forSharer:")]
        bool AddToOfflineQueue (SHKItem item, string sharerId);
        
        [Static]
        [Export ("flushOfflineQueue")]
        void FlushOfflineQueue ();

        //[Export ("error"), Internal]
        //NSError Error (string description, params object[] args);

        [Export ("connected")]
        bool Connected ();
        
    }

    [BaseType (typeof (UIActionSheet))]
    interface SHKActionSheet {
        [Export ("item")]
        SHKItem Item { get; set;  }

        [Wrap ("WeakShareDelegate")]
        SHKShareItemDelegate ShareDelegate { get; set; }
        
        [Export ("shareDelegate")]
        NSObject WeakShareDelegate { get; set;  }
        
        [Export ("sharers")]
        NSMutableArray Sharers ();
        
        [Static]
        [Export ("actionSheetForType:")]
        SHKActionSheet ActionSheetForType (SHKShareType type);
        
        [Static]
        [Export ("actionSheetForItem:")]
        SHKActionSheet ActionSheetForItem (SHKItem i);
        
    }
    
    [BaseType (typeof (NSObject))]
    interface SHKConfiguration {
        [Static]
        [Export ("sharedInstanceWithConfigurator:")]
        SHKConfiguration SharedInstanceWithConfigurator (DefaultSHKConfigurator config);
        
        [Export ("configurationValue:withObject:")]
        NSObject ConfigurationValuewithObject (string selector, NSObject obj);
        
    }
    
    [BaseType (typeof (SHKFormControllerLargeTextField))]
    interface SHKCustomFormControllerLargeTextField {
    }
    
    [BaseType (typeof (SHKFormFieldCell))]
    interface SHKCustomFormFieldCell {
    }
    
    [BaseType (typeof (NSObject))]
    interface SHKItem {
        [Export ("URL")]
        NSUrl URL { get; set;  }
        
        [Export ("URLContentType")]
        SHKURLContentType URLContentType { get; set;  }
        
        [Export ("image")]
        UIImage Image { get; set;  }
        
        [Export ("title")]
        string Title { get; set;  }
        
        [Export ("text")]
        string Text { get; set;  }
        
        [Export ("tags")]
        NSArray Tags { get; set;  }

        [Export ("data")]
        NSData Data { get; set;  }
        
        [Export ("mimeType")]
        string MimeType { get; set;  }
        
        [Export ("filename")]
        string Filename { get; set;  }
        
        [Export ("printOutputType")]
        UIPrintInfoOutputType PrintOutputType { get; set;  }
        
        [Export ("mailToRecipients")]
        string[] MailToRecipients { get; set;  }
        
        [Export ("isMailHTML")]
        bool IsMailHTML { get; set;  }
        
        [Export ("mailJPGQuality")]
        float MailJPGQuality { get; set;  }
        
        [Export ("mailShareWithAppSignature")]
        bool MailShareWithAppSignature { get; set;  }
        
        [Export ("facebookURLSharePictureURI")]
        string FacebookURLSharePictureURI { get; set;  }
        
        [Export ("facebookURLShareDescription")]
        string FacebookURLShareDescription { get; set;  }
        
        [Export ("textMessageToRecipients")]
        string[] TextMessageToRecipients { get; set;  }
        
        [Export ("popOverSourceRect")]
        RectangleF PopOverSourceRect { get; set;  }
        
        [Export ("shareType")]
        SHKShareType ShareType { get; set; }

        [Static]
        [Export ("URL:title:contentType:")]
        SHKItem Create (NSUrl url, string title, SHKURLContentType type);
        
        [Static]
        [Export ("image:title:")]
        SHKItem Create (UIImage image, string title);
        
        [Static]
        [Export ("text:")]
        SHKItem Create (string text);
        
        [Static]
        [Export ("file:filename:mimeType:title:")]
        SHKItem Create (NSData data, string filename, string mimeType, string title);
        
        [Export ("setCustomValue:forKey:")]
        void SetCustomValue (string value, string key);
        
        [Export ("customValueForKey:")]
        string CustomValueForKey (string key);
        
        [Export ("customBoolForSwitchKey:")]
        bool CustomBoolForSwitchKey (string key);
        
        [Export ("dictionaryRepresentation")]
        NSDictionary DictionaryRepresentation ();
        
        [Static]
        [Export ("itemFromDictionary:")]
        NSObject ItemFromDictionary (NSDictionary dictionary);
        
    }

    [BaseType (typeof (NSObject))]                                                                                                                     
    [Model]                                                                                                                                            
    interface SHKShareItemDelegate {                                                                                                                   
        [Abstract]                                                                                                                                 
        [Export ("aboutToShareItem:withSharer:")]                                                                                                  
        bool AboutToShareItem (SHKItem item, SHKSharer sharer);                                                                          
        
    }      

    [BaseType (typeof (NSObject))]
    [Model]
    interface SHKSharerDelegate {
        [Abstract]
        [Export ("sharerStartedSending:")]
        void StartedSending (SHKSharer sharer);
        
        [Abstract]
        [Export ("sharerFinishedSending:")]
        void FinishedSending (SHKSharer sharer);
        
        [Abstract]
        [Export ("sharer:failedWithError:shouldRelogin:")]
        void FailedWithError (SHKSharer sharer, NSError error, bool shouldRelogin);
        
        [Abstract]
        [Export ("sharerCancelledSending:")]
        void CancelledSending (SHKSharer sharer);
        
        [Abstract]
        [Export ("sharerShowBadCredentialsAlert:")]
        void ShowBadCredentialsAlert (SHKSharer sharer);
        
        [Abstract]
        [Export ("sharerShowOtherAuthorizationErrorAlert:")]
        void ShowOtherAuthorizationErrorAlert (SHKSharer sharer);
        
        [Abstract]
        [Export ("sharerAuthDidFinish:success:")]
        void AuthDidFinish (SHKSharer sharer, bool success);
        
    }
    
    [BaseType (typeof (UINavigationController))]
    interface SHKSharer {
        [Export ("item")]
        SHKItem Item { get; set;  }
        
        [Export ("pendingForm")]
        SHKFormController PendingForm { get; set;  }
        
        [Export ("request")]
        SHKRequest Request { get; set;  }
        
        [Export ("lastError")]
        NSError LastError { get; set;  }
        
        [Export ("quiet")]
        bool Quiet { get; set;  }
        
        [Export ("pendingAction")]
        SHKSharerPendingAction PendingAction { get; set;  }
        
        [Wrap ("WeakShareDelegate")]
        SHKSharerDelegate ShareDelegate { get; set; }
        
        [Export ("shareDelegate")]
        NSObject WeakShareDelegate { get; set;  }

        [Export ("sharerTitle")]
        string SharerTitle ();
        
        [Export ("sharerId")]
        string SharerId ();
        
        [Static]
        [Export ("canShareText")]
        bool CanShareText ();
        
        [Static]
        [Export ("canShareURL")]
        bool CanShareURL ();
        
        [Static]
        [Export ("canShareImage")]
        bool CanShareImage ();
        
        [Static]
        [Export ("canShareFile")]
        bool CanShareFile ();
        
        [Static]
        [Export ("canGetUserInfo")]
        bool CanGetUserInfo ();
        
        [Static]
        [Export ("shareRequiresInternetConnection")]
        bool ShareRequiresInternetConnection ();
        
        [Static]
        [Export ("canShareOffline")]
        bool CanShareOffline ();
        
        [Static]
        [Export ("requiresAuthentication")]
        bool RequiresAuthentication ();
        
        [Static]
        [Export ("canShareType:")]
        bool CanShareType (SHKShareType type);
        
        [Static]
        [Export ("canAutoShare")]
        bool CanAutoShare ();
        
        [Export ("canShare")]
        bool CanShare ();
        
        [Export ("shouldAutoShare")]
        bool ShouldAutoShare ();

        [Static]
        [Export ("shareItem:")]
        NSObject ShareItem (SHKItem i);
        
        [Export ("loadItem:")]
        void LoadItem (SHKItem i);
        
        [Static]
        [Export ("shareURL:")]
        NSObject ShareURL (NSUrl url);
        
        [Static]
        [Export ("shareURL:title:")]
        NSObject ShareURL (NSUrl url, string title);
        
        [Static]
        [Export ("shareImage:title:")]
        NSObject ShareImage (UIImage image, string title);
        
        [Static]
        [Export ("shareText:")]
        NSObject ShareText (string text);
        
        [Static]
        [Export ("shareFile:filename:mimeType:title:")]
        NSObject ShareFile (NSData file, string filename, string mimeType, string title);
        
        [Static]
        [Export ("getUserInfo")]
        NSObject GetUserInfo ();
        
        [Export ("share")]
        void Share ();
        
        [Export ("isAuthorized")]
        bool IsAuthorized ();
        
        [Export ("authorize")]
        bool Authorize ();
        
        [Export ("promptAuthorization")]
        void PromptAuthorization ();
        
        [Export ("getAuthValueForKey:")]
        string GetAuthValueForKey (string key);
        
        [Export ("authorizationFormShow")]
        void AuthorizationFormShow ();
        
        [Export ("authorizationFormValidate:")]
        void AuthorizationFormValidate (SHKFormController form);
        
        [Export ("authorizationFormSave:")]
        void AuthorizationFormSave (SHKFormController form);
        
        [Export ("authorizationFormCancel:")]
        void AuthorizationFormCancel (SHKFormController form);
        
        [Export ("authorizationFormFields")]
        SHKFormFieldSettings[] AuthorizationFormFields ();
        
        [Export ("authorizationFormCaption")]
        string AuthorizationFormCaption ();
        
        [Static]
        [Export ("authorizationFormFields")]
        SHKFormFieldSettings[] SharedAuthorizationFormFields ();
        
        [Static]
        [Export ("authorizationFormCaption")]
        string SharedAuthorizationFormCaption ();
        
        [Static]
        [Export ("logout")]
        void Logout ();
        
        [Static]
        [Export ("isServiceAuthorized")]
        bool IsServiceAuthorized ();
        
        [Export ("tagStringJoinedBy:allowedCharacters:tagPrefix:tagSuffix:")]
        string TagStringJoinedBy (string joinString, NSCharacterSet charset, string prefixString, string suffixString);
        
        [Export ("validateItem")]
        bool ValidateItem ();
        
        [Export ("tryToSend")]
        bool TryToSend ();
        
        [Export ("send")]
        bool Send ();
        
        [Export ("show")]
        void Show ();
        
        [Export ("shareFormFieldsForType:")]
        NSArray ShareFormFieldsForType (SHKShareType type);
        
        [Export ("shareFormValidate:")]
        void ShareFormValidate (SHKFormController form);
        
        [Export ("shareFormSave:")]
        void ShareFormSave (SHKFormController form);
        
        [Export ("shareFormCancel:")]
        void ShareFormCancel (SHKFormController form);
        
        [Export ("tryPendingAction")]
        void TryPendingAction ();
        
        [Export ("sendDidStart")]
        void SendDidStart ();
        
        [Export ("sendDidFinish")]
        void SendDidFinish ();
        
        [Export ("shouldReloginWithPendingAction:")]
        void ShouldReloginWithPendingAction (SHKSharerPendingAction action);
        
        [Export ("sendDidFailWithError:")]
        void SendDidFailWithError (NSError error);
        
        [Export ("sendDidFailWithError:shouldRelogin:")]
        void SendDidFailWithError (NSError error, bool shouldRelogin);
        
        [Export ("sendDidCancel")]
        void SendDidCancel ();
        
        [Export ("authShowBadCredentialsAlert")]
        void AuthShowBadCredentialsAlert ();
        
        [Export ("authShowOtherAuthorizationErrorAlert")]
        void AuthShowOtherAuthorizationErrorAlert ();
        
        [Export ("sendShowSimpleErrorAlert")]
        void SendShowSimpleErrorAlert ();
        
        [Export ("authDidFinish:")]
        void AuthDidFinish (bool success);
        
    }

    [BaseType (typeof (SHKSharer))]
    interface SHKTumblr {
        [Static, New]
        [Export ("canShareText")]
        bool CanShareText ();
        
        [Static, New]
        [Export ("canShareURL")]
        bool CanShareURL ();
        
        [Static, New]
        [Export ("canShareImage")]
        bool CanShareImage ();
        
        [Static, New]
        [Export ("canShareFile")]
        bool CanShareFile ();
        
        [Static, New]
        [Export ("canGetUserInfo")]
        bool CanGetUserInfo ();
        
        [Static, New]
        [Export ("shareRequiresInternetConnection")]
        bool ShareRequiresInternetConnection ();
        
        [Static, New]
        [Export ("canShareOffline")]
        bool CanShareOffline ();
        
        [Static, New]
        [Export ("requiresAuthentication")]
        bool RequiresAuthentication ();
        
        [Static, New]
        [Export ("canShareType:")]
        bool CanShareType (SHKShareType type);
        
        [Static, New]
        [Export ("canAutoShare")]
        bool CanAutoShare ();

        [Static, New]
        [Export ("shareItem:")]
        NSObject ShareItem (SHKItem i);

        [Static, New]
        [Export ("shareURL:")]
        NSObject ShareURL (NSUrl url);
        
        [Static, New]
        [Export ("shareURL:title:")]
        NSObject ShareURL (NSUrl url, string title);
        
        [Static, New]
        [Export ("shareImage:title:")]
        NSObject ShareImage (UIImage image, string title);
        
        [Static, New]
        [Export ("shareText:")]
        NSObject ShareText (string text);
        
        [Static, New]
        [Export ("shareFile:filename:mimeType:title:")]
        NSObject ShareFile (NSData file, string filename, string mimeType, string title);
        
        [Static, New]
        [Export ("getUserInfo")]
        NSObject GetUserInfo ();
        
        [Static, New]
        [Export ("authorizationFormFields")]
        SHKFormFieldSettings[] SharedAuthorizationFormFields ();
        
        [Static, New]
        [Export ("authorizationFormCaption")]
        string SharedAuthorizationFormCaption ();
        
        [Static, New]
        [Export ("logout")]
        void Logout ();
        
        [Static, New]
        [Export ("isServiceAuthorized")]
        bool IsServiceAuthorized ();
    }

    [BaseType (typeof (NSObject))]
    interface SHKFormFieldSettings {
        [Export ("key")]
        string Key { get; set;  }
        
        [Export ("type")]
        SHKFormFieldType Type { get; set;  }
        
        [Export ("start")]
        string Start { get; set;  }
        
        [Export ("value")]
        string Value { get; set;  }
        
        [Export ("optionDetailLabelDefault")]
        string OptionDetailLabelDefault { get; set;  }
        
        [Export ("optionPickerInfo")]
        NSMutableDictionary OptionPickerInfo ();
        
        [Static]
        [Export ("label:key:type:start:")]
        SHKFormFieldSettings Create (string l, string k, SHKFormFieldType t, string s);
        
        [Static]
        [Export ("label:key:type:start:optionPickerInfo:optionDetailLabelDefault:")]
        SHKFormFieldSettings Create (string l, string k, SHKFormFieldType t, string s, NSMutableDictionary oi, string od);
        
        [Export ("optionPickerValueForIndexes:")]
        string OptionPickerValueForIndexes (string indexes);
        
    }

    
    [BaseType (typeof (UITableViewController))]
    interface SHKFormController {
        [Export ("validateSelector")]
        Selector ValidateSelector { get; set;  }
        
        [Export ("saveSelector")]
        Selector SaveSelector { get; set;  }
        
        [Export ("cancelSelector")]
        Selector CancelSelector { get; set;  }
        
        [Export ("sections")]
        NSMutableArray Sections { get; set;  }
        
        [Export ("autoSelect")]
        bool AutoSelect { get; set;  }
        
        [Export ("initWithStyle:title:rightButtonTitle:")]
        IntPtr Constructor (UITableViewStyle style, string barTitle, string rightButtonTitle);
        
        [Export ("addSection:header:footer:")]
        void AddSection (NSArray fields, string header, string footer);
        
        [Export ("rowSettingsForIndexPath:")]
        SHKFormFieldSettings RowSettings (NSIndexPath indexPath);
        
        [Export ("close")]
        void Close ();
        
        [Export ("cancel")]
        void Cancel ();
        
        [Export ("validateForm")]
        void ValidateForm ();
        
        [Export ("saveForm")]
        void SaveForm ();
        
        [Export ("formValues")]
        NSMutableDictionary FormValues ();
        
        [Export ("formValuesForSection:")]
        NSMutableDictionary FormValues (int section);
        
    }
    
    [BaseType (typeof (NSObject))]
    interface SHKRequest {
        [Export ("params")]
        string Params { get; set;  }
        
        [Export ("method")]
        string Method { get; set;  }
        
        [Export ("headerFields")]
        NSDictionary HeaderFields { get; set;  }
        
        [Export ("delegate")]
        NSObject Delegate { get; set;  }
        
        [Export ("isFinishedSelector", ArgumentSemantic.Assign)]
        Selector IsFinishedSelector { get; set;  }
        
        [Export ("connection")]
        NSUrlConnection Connection { get; set;  }
        
        [Export ("response")]
        NSHttpUrlResponse Response { get; set;  }

        [Export ("headers")]
        NSDictionary Headers { get; set;  }
        
        [Export ("data")]
        NSMutableData Data { get; set;  }
        
        [Export ("result")]
        string Result { [Bind ("getResult")] get; set;  }
        
        [Export ("success")]
        bool Success { get; set;  }
        
        [Export ("url")]
        NSUrl Url ();
        
        [Export ("initWithURL:params:delegate:isFinishedSelector:method:autostart:")]
        IntPtr Constructor (NSUrl u, string p, NSObject d, Selector s, string m, bool autostart);
        
        [Export ("start")]
        void Start ();
        
        [Export ("finish")]
        void Finish ();
        
    }

    [BaseType (typeof (UIViewController))]
    interface SHKFormControllerLargeTextField {
        [Export ("textView")]
        UITextView TextView { get; set;  }
        
        [Export ("maxTextLength")]
        uint MaxTextLength { get; set;  }
        
        [Export ("image")]
        UIImage Image { get; set;  }
        
        [Export ("imageTextLength")]
        uint ImageTextLength { get; set;  }
        
        [Export ("hasLink")]
        bool HasLink { get; set;  }
        
        [Export ("allowSendingEmptyMessage")]
        bool AllowSendingEmptyMessage { get; set;  }
        
        [Export ("text")]
        string Text { get; set; }
        
        [Export ("initWithNibName:bundle:delegate:")]
        IntPtr Constructor (string nibNameOrNil, NSBundle nibBundleOrNil, SHKFormControllerLargeTextFieldDelegate aDelegate);

        [Wrap ("WeakDelegate")]
        SHKFormControllerLargeTextFieldDelegate Delegate { get; set; }

        [Export ("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }
        
    }
    
    [BaseType (typeof (NSObject))]
    [Model]
    interface SHKFormControllerLargeTextFieldDelegate {
        [Abstract]
        [Export ("sendForm:")]
        void SendForm (SHKFormControllerLargeTextField form);
        
        [Abstract]
        [Static]
        [Export ("sharerTitle")]
        string SharerTitle ();
        
        [Abstract]
        [Export ("sendDidCancel")]
        void SendDidCancel ();
        
    }
    
    [BaseType (typeof (NSObject))]
    [Model]
    interface SHKFormFieldCellDelegate {
        [Abstract]
        [Export ("setActiveTextField:")]
        void SetActiveTextField (UITextField activeTextField);
        
    }
    
    [BaseType (typeof (UITableViewCell))]
    interface SHKFormFieldCell {
        [Export ("setupLayout")]
        void SetupLayout ();
        
        [Export ("setupWithSettings:settings")]
        void SetupWithSettingssettings (SHKFormFieldSettings _settings);
        
        [Export ("userSetValue:")]
        void UserSetValue (string newValue);

        [Wrap ("WeakDelegate")]
        SHKFormFieldCellDelegate Delegate { get; set; }
        
        [Export ("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }
    }
}

