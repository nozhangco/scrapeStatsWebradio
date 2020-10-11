#import "BuzzerBuilderWrapper.h"
#import "StarObjectManager.h"
#import "StarIO10ValueConverter.h"
#import <React/RCTLog.h>

@import StarIO10;

@interface BuzzerBuilderWrapper()

@property(assign, nonatomic) StarObjectManager *objManager;

@end


@implementation BuzzerBuilderWrapper

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
    STARIO10StarXpandCommandBuzzerBuilder *builder = [[STARIO1