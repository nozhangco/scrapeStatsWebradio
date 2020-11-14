#import "StarXpandCommandBuilderWrapper.h"
#import "StarObjectManager.h"
#import <React/RCTLog.h>

@import StarIO10;

@interface StarXpandCommandBuilderWrapper()

@property(assign, nonatomic) StarObjectManager *objManager;

@end

@implementation StarXpandCommandBuilderWrapper

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
                 createWithResolver:(RCTPro