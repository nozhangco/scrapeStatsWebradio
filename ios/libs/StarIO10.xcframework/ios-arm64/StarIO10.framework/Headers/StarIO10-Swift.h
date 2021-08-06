// Generated by Apple Swift version 5.5.2 (swiftlang-1300.0.47.5 clang-1300.0.29.30)
#ifndef STARIO10_SWIFT_H
#define STARIO10_SWIFT_H
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wgcc-compat"

#if !defined(__has_include)
# define __has_include(x) 0
#endif
#if !defined(__has_attribute)
# define __has_attribute(x) 0
#endif
#if !defined(__has_feature)
# define __has_feature(x) 0
#endif
#if !defined(__has_warning)
# define __has_warning(x) 0
#endif

#if __has_include(<swift/objc-prologue.h>)
# include <swift/objc-prologue.h>
#endif

#pragma clang diagnostic ignored "-Wauto-import"
#include <Foundation/Foundation.h>
#include <stdint.h>
#include <stddef.h>
#include <stdbool.h>

#if !defined(SWIFT_TYPEDEFS)
# define SWIFT_TYPEDEFS 1
# if __has_include(<uchar.h>)
#  include <uchar.h>
# elif !defined(__cplusplus)
typedef uint_least16_t char16_t;
typedef uint_least32_t char32_t;
# endif
typedef float swift_float2  __attribute__((__ext_vector_type__(2)));
typedef float swift_float3  __attribute__((__ext_vector_type__(3)));
typedef float swift_float4  __attribute__((__ext_vector_type__(4)));
typedef double swift_double2  __attribute__((__ext_vector_type__(2)));
typedef double swift_double3  __attribute__((__ext_vector_type__(3)));
typedef double swift_double4  __attribute__((__ext_vector_type__(4)));
typedef int swift_int2  __attribute__((__ext_vector_type__(2)));
typedef int swift_int3  __attribute__((__ext_vector_type__(3)));
typedef int swift_int4  __attribute__((__ext_vector_type__(4)));
typedef unsigned int swift_uint2  __attribute__((__ext_vector_type__(2)));
typedef unsigned int swift_uint3  __attribute__((__ext_vector_type__(3)));
typedef unsigned int swift_uint4  __attribute__((__ext_vector_type__(4)));
#endif

#if !defined(SWIFT_PASTE)
# define SWIFT_PASTE_HELPER(x, y) x##y
# define SWIFT_PASTE(x, y) SWIFT_PASTE_HELPER(x, y)
#endif
#if !defined(SWIFT_METATYPE)
# define SWIFT_METATYPE(X) Class
#endif
#if !defined(SWIFT_CLASS_PROPERTY)
# if __has_feature(objc_class_property)
#  define SWIFT_CLASS_PROPERTY(...) __VA_ARGS__
# else
#  define SWIFT_CLASS_PROPERTY(...)
# endif
#endif

#if __has_attribute(objc_runtime_name)
# define SWIFT_RUNTIME_NAME(X) __attribute__((objc_runtime_name(X)))
#else
# define SWIFT_RUNTIME_NAME(X)
#endif
#if __has_attribute(swift_name)
# define SWIFT_COMPILE_NAME(X) __attribute__((swift_name(X)))
#else
# define SWIFT_COMPILE_NAME(X)
#endif
#if __has_attribute(objc_method_family)
# define SWIFT_METHOD_FAMILY(X) __attribute__((objc_method_family(X)))
#else
# define SWIFT_METHOD_FAMILY(X)
#endif
#if __has_attribute(noescape)
# define SWIFT_NOESCAPE __attribute__((noescape))
#else
# define SWIFT_NOESCAPE
#endif
#if __has_attribute(ns_consumed)
# define SWIFT_RELEASES_ARGUMENT __attribute__((ns_consumed))
#else
# define SWIFT_RELEASES_ARGUMENT
#endif
#if __has_attribute(warn_unused_result)
# define SWIFT_WARN_UNUSED_RESULT __attribute__((warn_unused_result))
#else
# define SWIFT_WARN_UNUSED_RESULT
#endif
#if __has_attribute(noreturn)
# define SWIFT_NORETURN __attribute__((noreturn))
#else
# define SWIFT_NORETURN
#endif
#if !defined(SWIFT_CLASS_EXTRA)
# define SWIFT_CLASS_EXTRA
#endif
#if !defined(SWIFT_PROTOCOL_EXTRA)
# define SWIFT_PROTOCOL_EXTRA
#endif
#if !defined(SWIFT_ENUM_EXTRA)
# define SWIFT_ENUM_EXTRA
#endif
#if !defined(SWIFT_CLASS)
# if __has_attribute(objc_subclassing_restricted)
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# else
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# endif
#endif
#if !defined(SWIFT_RESILIENT_CLASS)
# if __has_attribute(objc_class_stub)
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME) __attribute__((objc_class_stub))
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_class_stub)) SWIFT_CLASS_NAMED(SWIFT_NAME)
# else
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME)
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) SWIFT_CLASS_NAMED(SWIFT_NAME)
# endif
#endif

#if !defined(SWIFT_PROTOCOL)
# define SWIFT_PROTOCOL(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
# define SWIFT_PROTOCOL_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
#endif

#if !defined(SWIFT_EXTENSION)
# define SWIFT_EXTENSION(M) SWIFT_PASTE(M##_Swift_, __LINE__)
#endif

#if !defined(OBJC_DESIGNATED_INITIALIZER)
# if __has_attribute(objc_designated_initializer)
#  define OBJC_DESIGNATED_INITIALIZER __attribute__((objc_designated_initializer))
# else
#  define OBJC_DESIGNATED_INITIALIZER
# endif
#endif
#if !defined(SWIFT_ENUM_ATTR)
# if defined(__has_attribute) && __has_attribute(enum_extensibility)
#  define SWIFT_ENUM_ATTR(_extensibility) __attribute__((enum_extensibility(_extensibility)))
# else
#  define SWIFT_ENUM_ATTR(_extensibility)
# endif
#endif
#if !defined(SWIFT_ENUM)
# define SWIFT_ENUM(_type, _name, _extensibility) enum _name : _type _name; enum SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# if __has_feature(generalized_swift_name)
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) enum _name : _type _name SWIFT_COMPILE_NAME(SWIFT_NAME); enum SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# else
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) SWIFT_ENUM(_type, _name, _extensibility)
# endif
#endif
#if !defined(SWIFT_UNAVAILABLE)
# define SWIFT_UNAVAILABLE __attribute__((unavailable))
#endif
#if !defined(SWIFT_UNAVAILABLE_MSG)
# define SWIFT_UNAVAILABLE_MSG(msg) __attribute__((unavailable(msg)))
#endif
#if !defined(SWIFT_AVAILABILITY)
# define SWIFT_AVAILABILITY(plat, ...) __attribute__((availability(plat, __VA_ARGS__)))
#endif
#if !defined(SWIFT_WEAK_IMPORT)
# define SWIFT_WEAK_IMPORT __attribute__((weak_import))
#endif
#if !defined(SWIFT_DEPRECATED)
# define SWIFT_DEPRECATED __attribute__((deprecated))
#endif
#if !defined(SWIFT_DEPRECATED_MSG)
# define SWIFT_DEPRECATED_MSG(...) __attribute__((deprecated(__VA_ARGS__)))
#endif
#if __has_feature(attribute_diagnose_if_objc)
# define SWIFT_DEPRECATED_OBJC(Msg) __attribute__((diagnose_if(1, Msg, "warning")))
#else
# define SWIFT_DEPRECATED_OBJC(Msg) SWIFT_DEPRECATED_MSG(Msg)
#endif
#if !defined(IBSegueAction)
# define IBSegueAction
#endif
#if __has_feature(modules)
#if __has_warning("-Watimport-in-framework-header")
#pragma clang diagnostic ignored "-Watimport-in-framework-header"
#endif
@import Foundation;
@import ObjectiveC;
#endif

#pragma clang diagnostic ignored "-Wproperty-attribute-mismatch"
#pragma clang diagnostic ignored "-Wduplicate-method-arg"
#if __has_warning("-Wpragma-clang-attribute")
# pragma clang diagnostic ignored "-Wpragma-clang-attribute"
#endif
#pragma clang diagnostic ignored "-Wunknown-pragmas"
#pragma clang diagnostic ignored "-Wnullability"

#if __has_attribute(external_source_symbol)
# pragma push_macro("any")
# undef any
# pragma clang attribute push(__attribute__((external_source_symbol(language="Swift", defined_in="StarIO10",generated_declaration))), apply_to=any(function,enum,objc_interface,objc_category,objc_protocol))
# pragma pop_macro("any")
#endif


SWIFT_CLASS("_TtCC8StarIO1016StarXpandCommand5Bezel")
@interface Bezel : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Bezel (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandBezelLEDType, "LEDType", open) {
  STARIO10StarXpandCommandBezelLEDTypeHolding = 0,
  STARIO10StarXpandCommandBezelLEDTypeError = 1,
  STARIO10StarXpandCommandBezelLEDTypeIdle = 2,
};


@interface Bezel (SWIFT_EXTENSION(StarIO10))
@end

@class NSNumber;

SWIFT_CLASS_NAMED("LEDAutomaticBlinkParameter")
@interface STARIO10StarXpandCommandBezelLEDAutomaticBlinkParameter : NSObject
- (nonnull instancetype)initWithType:(enum STARIO10StarXpandCommandBezelLEDType)type OBJC_DESIGNATED_INITIALIZER;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandBezelLEDType type;
@property (nonatomic, readonly) NSInteger onTime;
- (nonnull instancetype)setOnTime:(NSInteger)onTime SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger offTime;
- (nonnull instancetype)setOffTime:(NSInteger)offTime SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


SWIFT_CLASS("_TtCC8StarIO1016StarXpandCommand6Buzzer")
@interface Buzzer : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Buzzer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandBuzzerChannel, "Channel", open) {
  STARIO10StarXpandCommandBuzzerChannelNo1 = 0,
  STARIO10StarXpandCommandBuzzerChannelNo2 = 1,
};


@interface Buzzer (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("DriveParameter")
@interface STARIO10StarXpandCommandBuzzerDriveParameter : NSObject
@property (nonatomic, readonly) enum STARIO10StarXpandCommandBuzzerChannel channel;
- (nonnull instancetype)setChannel:(enum STARIO10StarXpandCommandBuzzerChannel)channel SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger repeat;
- (nonnull instancetype)setRepeat:(NSInteger)repeat SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger onTime;
- (nonnull instancetype)setOnTime:(NSInteger)onTime SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger offTime;
- (nonnull instancetype)setOffTime:(NSInteger)offTime SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


SWIFT_CLASS("_TtCC8StarIO1016StarXpandCommand7Display")
@interface Display : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Display (SWIFT_EXTENSION(StarIO10))
@end

@class UIImage;

SWIFT_CLASS_NAMED("ImageParameter")
@interface STARIO10StarXpandCommandDisplayImageParameter : NSObject
@property (nonatomic, readonly, strong) UIImage * _Nonnull image;
@property (nonatomic, readonly) BOOL effectDiffusion;
- (nonnull instancetype)setEffectDiffusion:(BOOL)enable SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger threshold;
- (nonnull instancetype)setThreshold:(NSInteger)threshold SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)initWithImage:(UIImage * _Nonnull)image OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Display (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandDisplayInternationalCharacterType, "InternationalCharacterType", open) {
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeUsa = 0,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeFrance = 1,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeGermany = 2,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeUk = 3,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeDenmark = 4,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeSweden = 5,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeItaly = 6,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeSpain = 7,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeJapan = 8,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeNorway = 9,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeDenmark2 = 10,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeSpain2 = 11,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeLatinAmerica = 12,
  STARIO10StarXpandCommandDisplayInternationalCharacterTypeKorea = 13,
};


@interface Display (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandDisplayCursorState, "CursorState", open) {
  STARIO10StarXpandCommandDisplayCursorStateOn = 0,
  STARIO10StarXpandCommandDisplayCursorStateBlink = 1,
  STARIO10StarXpandCommandDisplayCursorStateOff = 2,
};


@interface Display (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("PositionParameter")
@interface STARIO10StarXpandCommandDisplayPositionParameter : NSObject
@property (nonatomic, readonly) NSInteger x;
@property (nonatomic, readonly) NSInteger y;
- (nonnull instancetype)initWithX:(NSInteger)x y:(NSInteger)y OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Display (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandDisplayContrast, "Contrast", open) {
  STARIO10StarXpandCommandDisplayContrastPlus3 = 0,
  STARIO10StarXpandCommandDisplayContrastPlus2 = 1,
  STARIO10StarXpandCommandDisplayContrastPlus1 = 2,
  STARIO10StarXpandCommandDisplayContrastDefault = 3,
  STARIO10StarXpandCommandDisplayContrastMinus1 = 4,
  STARIO10StarXpandCommandDisplayContrastMinus2 = 5,
  STARIO10StarXpandCommandDisplayContrastMinus3 = 6,
};


@interface Display (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandDisplayCharacterEncodingType, "CharacterEncodingType", open) {
  STARIO10StarXpandCommandDisplayCharacterEncodingTypeJapanese = 0,
  STARIO10StarXpandCommandDisplayCharacterEncodingTypeSimplifiedChinese = 1,
  STARIO10StarXpandCommandDisplayCharacterEncodingTypeTraditionalChinese = 2,
  STARIO10StarXpandCommandDisplayCharacterEncodingTypeKorean = 3,
  STARIO10StarXpandCommandDisplayCharacterEncodingTypeCodePage = 4,
};

@class STARIO10StarPrinter;

SWIFT_PROTOCOL_NAMED("DisplayDelegate")
@protocol STARIO10DisplayDelegate
- (void)displayWithPrinter:(STARIO10StarPrinter * _Nonnull)printer communicationErrorDidOccur:(NSError * _Nonnull)error;
- (void)displayDidConnectWithPrinter:(STARIO10StarPrinter * _Nonnull)printer;
- (void)displayDidDisconnectWithPrinter:(STARIO10StarPrinter * _Nonnull)printer;
@end


SWIFT_CLASS("_TtCC8StarIO1016StarXpandCommand6Drawer")
@interface Drawer : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Drawer (SWIFT_EXTENSION(StarIO10))
@end

enum STARIO10StarXpandCommandDrawerChannel : NSInteger;

SWIFT_CLASS_NAMED("OpenParameter")
@interface STARIO10StarXpandCommandDrawerOpenParameter : NSObject
@property (nonatomic, readonly) enum STARIO10StarXpandCommandDrawerChannel channel;
- (nonnull instancetype)setChannel:(enum STARIO10StarXpandCommandDrawerChannel)channel SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger onTime;
- (nonnull instancetype)setOnTime:(NSInteger)onTime SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Drawer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandDrawerChannel, "Channel", open) {
  STARIO10StarXpandCommandDrawerChannelNo1 = 0,
  STARIO10StarXpandCommandDrawerChannelNo2 = 1,
};


SWIFT_PROTOCOL_NAMED("DrawerDelegate")
@protocol STARIO10DrawerDelegate
- (void)drawerWithPrinter:(STARIO10StarPrinter * _Nonnull)printer communicationErrorDidOccur:(NSError * _Nonnull)error;
- (void)drawerWithPrinter:(STARIO10StarPrinter * _Nonnull)printer didSwitch:(BOOL)openCloseSignal;
@end

@class NSData;

SWIFT_PROTOCOL_NAMED("InputDeviceDelegate")
@protocol STARIO10InputDeviceDelegate
- (void)inputDeviceWithPrinter:(STARIO10StarPrinter * _Nonnull)printer communicationErrorDidOccur:(NSError * _Nonnull)error;
- (void)inputDeviceDidConnectWithPrinter:(STARIO10StarPrinter * _Nonnull)printer;
- (void)inputDeviceDidDisconnectWithPrinter:(STARIO10StarPrinter * _Nonnull)printer;
- (void)inputDeviceWithPrinter:(STARIO10StarPrinter * _Nonnull)printer didReceive:(NSData * _Nonnull)data;
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10InterfaceType, "InterfaceType", open) {
  STARIO10InterfaceTypeUnknown SWIFT_COMPILE_NAME("unknown") = 0,
  STARIO10InterfaceTypeUSB SWIFT_COMPILE_NAME("usb") = 1,
  STARIO10InterfaceTypeBluetooth SWIFT_COMPILE_NAME("bluetooth") = 2,
  STARIO10InterfaceTypeBluetoothLE SWIFT_COMPILE_NAME("bluetoothLE") = 3,
  STARIO10InterfaceTypeLAN SWIFT_COMPILE_NAME("lan") = 4,
};


SWIFT_CLASS("_TtC8StarIO108Internal")
@interface Internal : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end

@class NSString;

SWIFT_CLASS_NAMED("InternalInterface")
@interface STARIO10InternalInterface : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
+ (void)appendLogHeader:(NSString * _Nonnull)header;
@end


SWIFT_CLASS("_TtCC8StarIO1016StarXpandCommand13MelodySpeaker")
@interface MelodySpeaker : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface MelodySpeaker (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("DriveOneTimeSoundParameter")
@interface STARIO10StarXpandCommandMelodySpeakerDriveOneTimeSoundParameter : NSObject
@property (nonatomic, readonly, copy) NSData * _Nonnull source;
@property (nonatomic, readonly) NSInteger volume;
- (nonnull instancetype)setVolume:(NSInteger)volume SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)initWithSource:(NSData * _Nonnull)source OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface MelodySpeaker (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandMelodySpeakerSoundStorageArea, "SoundStorageArea", open) {
  STARIO10StarXpandCommandMelodySpeakerSoundStorageAreaArea1 = 0,
  STARIO10StarXpandCommandMelodySpeakerSoundStorageAreaArea2 = 1,
};


@interface MelodySpeaker (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("DriveRegisteredSoundParameter")
@interface STARIO10StarXpandCommandMelodySpeakerDriveRegisteredSoundParameter : NSObject
@property (nonatomic, readonly) enum STARIO10StarXpandCommandMelodySpeakerSoundStorageArea area;
@property (nonatomic, readonly) NSInteger number;
@property (nonatomic, readonly) NSInteger volume;
- (nonnull instancetype)setVolume:(NSInteger)volume SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)initWithArea:(enum STARIO10StarXpandCommandMelodySpeakerSoundStorageArea)area number:(NSInteger)number OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


SWIFT_CLASS("_TtCC8StarIO1016StarXpandCommand9Presenter")
@interface Presenter : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Presenter (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPresenterLEDType, "LEDType", open) {
  STARIO10StarXpandCommandPresenterLEDTypeHolding = 0,
  STARIO10StarXpandCommandPresenterLEDTypeError = 1,
  STARIO10StarXpandCommandPresenterLEDTypeIdle = 2,
};


@interface Presenter (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("ModeParameter")
@interface STARIO10StarXpandCommandPresenterModeParameter : NSObject
@property (nonatomic, readonly) BOOL loop;
- (nonnull instancetype)setLoop:(BOOL)loop SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) BOOL hold;
- (nonnull instancetype)setHold:(BOOL)hold SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) BOOL retract;
- (nonnull instancetype)setRetract:(BOOL)retract SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger holdTime;
- (nonnull instancetype)setHoldTime:(NSInteger)holdTime SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Presenter (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("LEDAutomaticBlinkParameter")
@interface STARIO10StarXpandCommandPresenterLEDAutomaticBlinkParameter : NSObject
- (nonnull instancetype)initWithType:(enum STARIO10StarXpandCommandPresenterLEDType)type OBJC_DESIGNATED_INITIALIZER;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandPresenterLEDType type;
@property (nonatomic, readonly) NSInteger onTime;
- (nonnull instancetype)setOnTime:(NSInteger)onTime SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger offTime;
- (nonnull instancetype)setOffTime:(NSInteger)offTime SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


SWIFT_CLASS("_TtCC8StarIO1016StarXpandCommand7Printer")
@interface Printer : NSObject
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterCJKCharacterType, "CJKCharacterType", open) {
  STARIO10StarXpandCommandPrinterCJKCharacterTypeJapanese = 0,
  STARIO10StarXpandCommandPrinterCJKCharacterTypeSimplifiedChinese = 1,
  STARIO10StarXpandCommandPrinterCJKCharacterTypeTraditionalChinese = 2,
  STARIO10StarXpandCommandPrinterCJKCharacterTypeKorean = 3,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterCutType, "CutType", open) {
  STARIO10StarXpandCommandPrinterCutTypeFull = 0,
  STARIO10StarXpandCommandPrinterCutTypePartial = 1,
  STARIO10StarXpandCommandPrinterCutTypeFullDirect = 2,
  STARIO10StarXpandCommandPrinterCutTypePartialDirect = 3,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("HoldPrintParameter")
@interface STARIO10StarXpandCommandPrinterHoldPrintParameter : NSObject
@property (nonatomic, readonly) BOOL enable;
- (nonnull instancetype)initWithEnable:(BOOL)enable OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterBarcodeBarRatioLevel, "BarcodeBarRatioLevel", open) {
  STARIO10StarXpandCommandPrinterBarcodeBarRatioLevelLevelPlus1 = 0,
  STARIO10StarXpandCommandPrinterBarcodeBarRatioLevelLevel0 = 1,
  STARIO10StarXpandCommandPrinterBarcodeBarRatioLevelLevelMinus1 = 2,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterBarcodeSymbology, "BarcodeSymbology", open) {
  STARIO10StarXpandCommandPrinterBarcodeSymbologyUpcE = 0,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyUpcA = 1,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyJan8 = 2,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyEan8 = 3,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyJan13 = 4,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyEan13 = 5,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyCode39 = 6,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyItf = 7,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyCode128 = 8,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyCode93 = 9,
  STARIO10StarXpandCommandPrinterBarcodeSymbologyNw7 = 10,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterInternationalCharacterType, "InternationalCharacterType", open) {
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeUsa = 0,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeFrance = 1,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeGermany = 2,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeUk = 3,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeDenmark = 4,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeSweden = 5,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeItaly = 6,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeSpain = 7,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeJapan = 8,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeNorway = 9,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeDenmark2 = 10,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeSpain2 = 11,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeLatinAmerica = 12,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeKorea = 13,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeIreland = 14,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeSlovenia = 15,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeCroatia = 16,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeChina = 17,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeVietnam = 18,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeArabic = 19,
  STARIO10StarXpandCommandPrinterInternationalCharacterTypeLegal = 20,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

enum STARIO10StarXpandCommandPrinterBlackMarkPosition : NSInteger;

SWIFT_CLASS_NAMED("BlackMarkParameter")
@interface STARIO10StarXpandCommandPrinterBlackMarkParameter : NSObject
@property (nonatomic, readonly) BOOL enable;
- (nonnull instancetype)setEnable:(BOOL)enable SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandPrinterBlackMarkPosition position;
- (nonnull instancetype)setPosition:(enum STARIO10StarXpandCommandPrinterBlackMarkPosition)position SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

enum STARIO10StarXpandCommandPrinterPDF417Level : NSInteger;

SWIFT_CLASS_NAMED("PDF417Parameter")
@interface STARIO10StarXpandCommandPrinterPDF417Parameter : NSObject
@property (nonatomic, readonly, copy) NSString * _Nonnull content;
@property (nonatomic, readonly) NSInteger column;
- (nonnull instancetype)setColumn:(NSInteger)column SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger line;
- (nonnull instancetype)setLine:(NSInteger)line SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly, getter=module) NSInteger module_;
- (nonnull instancetype)setModule:(NSInteger)module_ SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger aspect;
- (nonnull instancetype)setAspect:(NSInteger)aspect SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandPrinterPDF417Level level;
- (nonnull instancetype)setLevel:(enum STARIO10StarXpandCommandPrinterPDF417Level)level SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)initWithContent:(NSString * _Nonnull)content OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterQRCodeModel, "QRCodeModel", open) {
  STARIO10StarXpandCommandPrinterQRCodeModelModel1 = 0,
  STARIO10StarXpandCommandPrinterQRCodeModelModel2 = 1,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("BarcodeParameter")
@interface STARIO10StarXpandCommandPrinterBarcodeParameter : NSObject
@property (nonatomic, readonly, copy) NSString * _Nonnull content;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandPrinterBarcodeSymbology symbology;
@property (nonatomic, readonly) BOOL printHRI;
- (nonnull instancetype)setPrintHRI:(BOOL)printHRI SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger barDots;
- (nonnull instancetype)setBarDots:(NSInteger)barDots SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandPrinterBarcodeBarRatioLevel barRatioLevel;
- (nonnull instancetype)setBarRatioLevel:(enum STARIO10StarXpandCommandPrinterBarcodeBarRatioLevel)barRatioLevel SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) double height;
- (nonnull instancetype)setHeight:(double)height SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)initWithContent:(NSString * _Nonnull)content symbology:(enum STARIO10StarXpandCommandPrinterBarcodeSymbology)symbology OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterPDF417Level, "PDF417Level", open) {
  STARIO10StarXpandCommandPrinterPDF417LevelEcc0 = 0,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc1 = 1,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc2 = 2,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc3 = 3,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc4 = 4,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc5 = 5,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc6 = 6,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc7 = 7,
  STARIO10StarXpandCommandPrinterPDF417LevelEcc8 = 8,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterBlackMarkPosition, "BlackMarkPosition", open) {
  STARIO10StarXpandCommandPrinterBlackMarkPositionFront = 0,
  STARIO10StarXpandCommandPrinterBlackMarkPositionBack = 1,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterCharacterEncodingType, "CharacterEncodingType", open) {
  STARIO10StarXpandCommandPrinterCharacterEncodingTypeJapanese = 0,
  STARIO10StarXpandCommandPrinterCharacterEncodingTypeSimplifiedChinese = 1,
  STARIO10StarXpandCommandPrinterCharacterEncodingTypeTraditionalChinese = 2,
  STARIO10StarXpandCommandPrinterCharacterEncodingTypeKorean = 3,
  STARIO10StarXpandCommandPrinterCharacterEncodingTypeCodePage = 4,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("LogoParameter")
@interface STARIO10StarXpandCommandPrinterLogoParameter : NSObject
@property (nonatomic, readonly, copy) NSString * _Nonnull keyCode;
- (nonnull instancetype)initWithKeyCode:(NSString * _Nonnull)keyCode OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("LabelParameter")
@interface STARIO10StarXpandCommandPrinterLabelParameter : NSObject
- (BOOL)enable SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)setEnable:(BOOL)enable SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterQRCodeLevel, "QRCodeLevel", open) {
  STARIO10StarXpandCommandPrinterQRCodeLevelL = 0,
  STARIO10StarXpandCommandPrinterQRCodeLevelM = 1,
  STARIO10StarXpandCommandPrinterQRCodeLevelQ = 2,
  STARIO10StarXpandCommandPrinterQRCodeLevelH = 3,
};


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("ImageParameter")
@interface STARIO10StarXpandCommandPrinterImageParameter : NSObject
@property (nonatomic, readonly, strong) UIImage * _Nonnull image;
@property (nonatomic, readonly) NSInteger width;
@property (nonatomic, readonly) BOOL effectDiffusion;
- (nonnull instancetype)setEffectDiffusion:(BOOL)enable SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger threshold;
- (nonnull instancetype)setThreshold:(NSInteger)threshold SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)initWithImage:(UIImage * _Nonnull)image width:(NSInteger)width OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterAlignment, "Alignment", open) {
  STARIO10StarXpandCommandPrinterAlignmentLeft = 0,
  STARIO10StarXpandCommandPrinterAlignmentCenter = 1,
  STARIO10StarXpandCommandPrinterAlignmentRight = 2,
};




@interface Printer (SWIFT_EXTENSION(StarIO10))
@end


SWIFT_CLASS_NAMED("QRCodeParameter")
@interface STARIO10StarXpandCommandPrinterQRCodeParameter : NSObject
@property (nonatomic, readonly, copy) NSString * _Nonnull content;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandPrinterQRCodeModel model;
- (nonnull instancetype)setModel:(enum STARIO10StarXpandCommandPrinterQRCodeModel)model SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) enum STARIO10StarXpandCommandPrinterQRCodeLevel level;
- (nonnull instancetype)setLevel:(enum STARIO10StarXpandCommandPrinterQRCodeLevel)level SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic, readonly) NSInteger cellSize;
- (nonnull instancetype)setCellSize:(NSInteger)cellSize SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)initWithContent:(NSString * _Nonnull)content OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


@interface Printer (SWIFT_EXTENSION(StarIO10))
@end

typedef SWIFT_ENUM_NAMED(NSInteger, STARIO10StarXpandCommandPrinterFontType, "FontType", open) {
  STARIO10StarXpandCommandPrinterFontTypeA = 0,
  STARIO10StarXpandCommandPrinterFontTypeB = 1,
};


SWIFT_PROTOCOL_NAMED("PrinterDelegate")
@protocol STARIO10PrinterDelegate
- (void)printer:(STARIO10StarPrinter * _Nonnull)printer communicationErrorDidOccur:(NSError * _Nonnull)error;
- (void)printerIsReady:(STARIO10StarPrinter * _Nonnull)printer;
- (void)printerDidHaveError:(STARIO10StarPrinter * _Nonnull)printer;
- (void)printerIsPaperReady:(STARIO10StarPrinter * _Nonnull)printer;
- (void)printerIsPaperNearEmpty:(STARIO10StarPrinter * _Nonnull)printer;
- (void)printerIsPaperEmpty:(STARIO10StarPrinter * _Nonnull)printer;
- (void)printerIsCoverOpen:(STARIO10StarPrinter * _Nonnull)printer;
- (void)printerIsCoverClose:(STARIO10StarPrinter * _Nonnull)printer;
@end


SWIFT_CLASS_NAMED("StarConnectionSettings")
@interface STARIO10StarConnectionSettings : NSObject
@property (nonatomic, readonly, copy) NSString * _Nonnull description;
SWIFT_CLASS_PROPERTY(@property (nonatomic, class, readonly, copy) NSString * _Nonnull FIRST_FOUND_DEVICE;)
+ (NSString * _Nonnull)FIRST_FOUND_DEVICE SWIFT_WARN_UNUSED_RESULT;
@property (nonatomic) enum STARIO10InterfaceType interfaceType;
@property (nonatomic, copy) NSString * _Nonnull identifier;
@property (nonatomic) BOOL autoSwitchInterface;
- (nonnull instancetype)initWithInterfaceType:(enum STARIO10InterfaceType)interfaceType identifier:(NSString * _Nonnull)identifier autoSwitchInterface:(BOOL)autoSwitchInterface OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end

@protocol STARIO10StarDeviceDiscoveryManagerDelegate;

SWIFT_PROTOCOL_NAMED("StarDeviceDiscoveryManager")
@protocol STARIO10StarDeviceDiscoveryManager
@property (nonatomic, weak) id <STARIO10StarDeviceDiscoveryManagerDelegate> _Nullable delegate;
@property (nonatomic) NSInteger discoveryTime;
- (BOOL)startDiscoveryWithError:(NSError * _Nullable * _Nullable)error;
- (void)stopDiscovery;
@end


SWIFT_PROTOCOL_NAMED("StarDeviceDiscoveryManagerDelegate")
@protocol STARIO10StarDeviceDiscoveryManagerDelegate
- (void)manager:(id <STARIO10StarDeviceDiscoveryManager> _Nonnull)manager didFindPrinter:(STARIO10StarPrinter * _Nonnull)printer;
- (void)managerDidFinishDis