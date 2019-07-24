//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

using System;
using System.Runtime.InteropServices;

namespace Microsoft.CognitiveServices.Speech.Internal
{
    internal enum PropertyId
    {
        SpeechServiceConnection_Key = 1000,
        SpeechServiceConnection_Endpoint = 1001,
        SpeechServiceConnection_Region = 1002,
        SpeechServiceAuthorization_Token = 1003,
        SpeechServiceAuthorization_Type = 1004,
        SpeechServiceConnection_EndpointId = 1005,
        SpeechServiceConnection_ProxyHostName = 1100,
        SpeechServiceConnection_ProxyPort = 1101,
        SpeechServiceConnection_ProxyUserName = 1102,
        SpeechServiceConnection_ProxyPassword = 1103,
        SpeechServiceConnection_Url = 1104,
        SpeechServiceConnection_TranslationToLanguages = 2000,
        SpeechServiceConnection_TranslationVoice = 2001,
        SpeechServiceConnection_TranslationFeatures = 2002,
        SpeechServiceConnection_IntentRegion = 2003,
        SpeechServiceConnection_RecoMode = 3000,
        SpeechServiceConnection_RecoLanguage = 3001,
        Speech_SessionId = 3002,
        SpeechServiceConnection_SynthLanguage = 3100,
        SpeechServiceConnection_SynthVoice = 3101,
        SpeechServiceConnection_SynthOutputFormat = 3102,
        SpeechServiceConnection_InitialSilenceTimeoutMs = 3200,
        SpeechServiceConnection_EndSilenceTimeoutMs = 3201,
        SpeechServiceConnection_EnableAudioLogging = 3202,
        SpeechServiceResponse_RequestDetailedResultTrueFalse = 4000,
        SpeechServiceResponse_RequestProfanityFilterTrueFalse = 4001,
        SpeechServiceResponse_ProfanityOption = 4002,
        SpeechServiceResponse_PostProcessingOption = 4003,
        SpeechServiceResponse_RequestWordLevelTimestamps = 4004,
        SpeechServiceResponse_StablePartialResultThreshold = 4005,
        SpeechServiceResponse_OutputFormatOption = 4006,
        SpeechServiceResponse_TranslationRequestStablePartialResult = 4100,
        SpeechServiceResponse_JsonResult = 5000,
        SpeechServiceResponse_JsonErrorDetails = 5001,
        SpeechServiceResponse_RecognitionLatencyMs = 5002,
        CancellationDetails_Reason = 6000,
        CancellationDetails_ReasonText = 6001,
        CancellationDetails_ReasonDetailedText = 6002,
        LanguageUnderstandingServiceResponse_JsonResult = 7000,
        AudioConfig_DeviceNameForCapture = 8000,
        AudioConfig_NumberOfChannelsForCapture = 8001,
        AudioConfig_SampleRateForCapture = 8002,
        AudioConfig_BitsPerSampleForCapture = 8003,
        AudioConfig_AudioSource = 8004,
        Speech_LogFilename = 9001,
        Conversation_Secret_Key = 10000,
        Conversation_TaskDialogAppId = 10001,
        Conversation_Initial_Silence_Timeout = 10002,
        Conversation_From_Id = 10003,
        DataBuffer_TimeStamp = 11001,
        DataBuffer_UserId = 11002
    }
}