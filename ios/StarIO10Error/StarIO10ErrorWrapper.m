#import "StarIO10ErrorWrapper.h"
#import "StarObjectManager.h"
#import <React/RCTLog.h>

@import StarIO10;


@interface StarIO10ErrorWrapper()

@property(assign, nonatomic) StarObjectManager *objManager;

@end

@implementation StarIO10ErrorWrapper

NSString * const kSTARIO10ErrorTypeArgument = @"Argument";
NSString * const kSTARIO10ErrorTypeBadResponse = @"BadResponse";
NSString * const kSTARIO10ErrorTypeCommunication = @"Communication";
NSString * const kSTARIO10ErrorTypeIllegalDeviceState = @"IllegalDeviceState";
NSString * const kSTARIO10ErrorTypeInUse = @"InUse";
NSString * const kSTARIO10ErrorTypeInvalidOperation = @"InvalidOperation";
NSString * const kSTARIO10ErrorTypeNotFound = @"NotFound";
NSString * const kSTARIO10ErrorTypeUnprintable = @"Unprintable";
NSString * const kSTARIO10ErrorTypeUnsupportedModel = @"UnsupportedModel";
NSString * const kSTARIO10ErrorTypeUnknown = @"Unknown";

- (instancetype)init
{
    self = [super init];
    if (self) {
        _objManager = StarObjectManager.sharedManager;
    }
    return self;
}

+ (BOOL)requiresMainQueueSetup
{
    return NO;
}

RCT_EXPORT_MODULE()

RCT_REMAP_METHOD(dispose,
                 disposeWithObjectIdentifier:(nonnull NSString *)objID
                 resolver:(RCTPromiseResolveBlock)resolve
                 rejecter:(RCTPromiseRejectBlock)reject)
{
    [_objManager remove:objID];

    resolve(nil);
}

RCT_REMAP_METHOD(getType,
                 getTypeWithObjectIdentifier:(nonnull NSString *)objID
                 resolver:(RCTPromiseResolveBlock)resolve
                 rej