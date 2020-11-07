#import "PreSettingBuilderWrapper.h"
#import "StarObjectManager.h"
#import "StarXpandCommandBuilderWrapper.h"

@import StarIO10;

@interface PreSettingBuilderWrapper()

@property(assign, nonatomic) StarObjectManager *objManager;

@end


@implementation PreSettingBuilderWrapper

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
