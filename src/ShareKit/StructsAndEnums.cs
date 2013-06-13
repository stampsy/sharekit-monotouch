using System;

namespace ShareKit
{
    public enum SHKShareType
    {
        SHKShareTypeUndefined,
        SHKShareTypeURL,
        SHKShareTypeText,
        SHKShareTypeImage,
        SHKShareTypeFile,
        SHKShareTypeUserInfo
    }
    
    public enum SHKURLContentType
    {
        SHKURLContentTypeUndefined,
        SHKURLContentTypeWebpage,
        SHKURLContentTypeAudio,
        SHKURLContentTypeVideo,
    }

    public enum SHKSharerPendingAction                                                                                                                                        
    {                                                                                                                                                          
        SHKPendingNone,                                                                                                                                    
        SHKPendingShare, //when ShareKit detects invalid credentials BEFORE user sends. User continues editing share content after login.                  
        SHKPendingRefreshToken, //when OAuth token expires                                                                                                 
        SHKPendingSend, //when ShareKit detects invalid credentials AFTER user sends. Item is resent without showing edit dialogue (user edited already).      
    }

    public enum SHKFormFieldType
    {                                                                                                                                                          
        SHKFormFieldTypeText,                                                                                                                              
        SHKFormFieldTypeTextNoCorrect,                                                                                                                     
        SHKFormFieldTypePassword,                                                                                                                          
        SHKFormFieldTypeSwitch,                                                                                                                            
        SHKFormFieldTypeOptionPicker                                                                                                                       
    }                                                                                                                                        

}

