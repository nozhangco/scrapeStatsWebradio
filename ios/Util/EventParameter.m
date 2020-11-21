//
//  EventParameter.m
//  react-native-star-io10
//
//  Created by 上田　雄磨 on 2020/10/23.
//

#import "EventParameter.h"

@implementation EventParameter

NSString * const kKeyIdentifier = @"identifier";
NSString * const kKeyErrorIdentifier = @"errorIdentifier";
NSString * const kKeyDraweOpenCloseSognalState = @"openCloseSignal";
NSString * const kKeyInputDeviceData = @"data";
NSString * const kKeyInterfaceType = @"interfaceType";
NSString * const kKeyConnectionIdentifier = @"connectionIdentifier";
NSString * const kKeyModel = @"model";
NSString * const kKeyEmulation = @"emulation";
NSString * const kKeyReserved = @"reserved";

NSString * const kNamePrinterDelegateReady = @"PrinterReady";
NSString * const kNamePrinterDelegateError = @"PrinterError";
NSString * const kNamePrinterDelegatePaperReady = @"PrinterPaperReady";
NSString * const kNamePrinterDelegatePaperNearEmpty = @"PrinterPaperNearEmpty";
NSString * const kNamePrinterDelegatePaperEmpty = @"PrinterPaperEmpty";
NSString *