#import "DisplayBuilderWrapper.h"
#import "StarObjectManager.h"
#import "StarIO10ValueConverter.h"
#import <React/RCTLog.h>

@import StarIO10;

@interface DisplayBuilderWrapper()

@property(assign, nonatomic) StarObjectManager *objManager;

@end

@implementation DisplayBuilderWrapper

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

RCT_REMAP_METHOD(init,
                 createWithResolver:(RCTPromiseResolveBlock)resolve
                 rejecter:(RCTPromiseRejectBlock)reject)
{
    STARIO10StarXpandCommandDisplayBuilder *builder = [[STARIO10StarXpandCommandDisplayBuilder alloc] init];
    
    if (builder == nil) {
        reject(@"Error", @"Fail to create object.", nil);
        return;
    }
    
    NSString *objID = [_objManager add:builder];
    
    resolve(objID);
}

RCT_REMAP_METHOD(dispose,
                 disposeWithObjectIdentifier:(nonnull NSString *)objID
                 resolver:(RCTPromiseResolveBlock)resolve
                 rejecter:(RCTPromiseRejectBlock)reject)
{
    [_objManager remove:objID];
    
    resolve(nil);
}

RCT_REMAP_METHOD(styleInternationalCharacter,
                 styleInternationalCharacterWithObjectIdentifier:(nonnull NSString *)objID
                 type:(nonnull NSString *)type
                 resolver:(RCTPromiseResolveBlock)resolve
                 rejecter:(RCTPromiseRejectBlock)reject)
{
    STARIO10StarXpandCommandDisplayBuilder *builder = [_objManager getObject:objID];
    
    if (builder == nil) {
        reject(@"Error", @"Fail to get object.", nil);
        return;
    }
    
    STARIO10StarXpandCommandDisplayInternationalCharacterType nativeType = [StarIO10ValueConverter toDisplayInternationalCharacterType:type];
    
    [builder styleInternationalCharacter:nativeType];
    
    resolve(nil);
}

RCT_REMAP_METHOD(styleCharacterEncoding,
                 styleCharacterEncodingWithObjectIdentifier:(nonnull NSString *)objID
                 type:(nonnull NSString *)type
                 resolver:(RCTPromiseResolveBlock)resolve
                 rejecter:(RCTPromiseRejectBlock)reject)
{
    STARIO10StarXpandCommandDisplayBuilder *builder = [_objManager getObject:objID];
    
    if (builder == nil) {
        reject(@"Error", @"Fail to get object.", nil);
        return;
    }
    
    STARIO10StarXpandCommandDisplayCharacterEncodingType nativeType = [StarIO10ValueConverter toDisplayCharacterEncodingType:type];
    
    [builder styleCharacterEncoding:nativeType];
    
    resolve(nil);
}

RCT_REMAP_METHOD(styleCursorPositionTo,
                 styleCursorPositionToWithObjectIdentifier:(nonnull NSString *)objID
                 x:(nonnull NSNumber *)x
                 y:(nonnull NSNumber *)y
                 resolver:(RCTPromiseResolveBlock)resolve
                 rejecter:(RCTPromiseRejectBlock)reject)
{
    STARIO10StarXpandCommandDisplayBuilder *builder = [_objManager getObject:objID];
    
    if (builder == nil) {
        reject(@"Error", @"Fail to get object.", nil);
        return;
    }
    
    STARIO10StarXpandCommandDisplayPositionParameter *param = [StarIO10ValueConverter toDisplayPositionParameterWithX:x y:y];
    
    [builder styleCursorPo