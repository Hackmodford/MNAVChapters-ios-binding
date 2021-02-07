using System;
using AVFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MNAVChaptersAbstractions
{
	// @interface MNAVChapter : NSObject
	[BaseType(typeof(NSObject))]
	interface MNAVChapter
	{
		// @property (copy, nonatomic) NSString * identifier;
		[Export("identifier")] string Identifier { get; set; }

		// @property (assign, nonatomic) BOOL hidden;
		[Export("hidden")] bool IsHidden { get; set; }

		// @property (copy, nonatomic) NSString * title;
		[Export("title")] string Title { get; set; }

		// @property (copy, nonatomic) NSString * url;
		[Export("url")] string Url { get; set; }

		// @property (nonatomic) CMTime time;
		[Export("time", ArgumentSemantic.Assign)]
		CMTime Time { get; set; }

		// @property (nonatomic) CMTime duration;
		[Export("duration", ArgumentSemantic.Assign)]
		CMTime Duration { get; set; }

		// @property (nonatomic) UIImage * artwork;
		[Export("artwork", ArgumentSemantic.Assign)]
		UIImage Artwork { get; set; }

		// -(BOOL)isEqualToChapter:(MNAVChapter *)aChapter;
		[Export("isEqualToChapter:")]
		bool Equals(MNAVChapter aChapter);

		// -(MNAVChapter *)initWithTime:(CMTime)time duration:(CMTime)duration;
		[Export("initWithTime:duration:")]
		IntPtr Constructor(CMTime time, CMTime duration);

		// +(MNAVChapter *)chapterWithTime:(CMTime)time duration:(CMTime)duration;
		// [Static]
		// [Export("chapterWithTime:duration:")]
		// MNAVChapter ChapterWithTime(CMTime time, CMTime duration);
	}

// @interface MNAVChapterReader : NSObject
	[BaseType(typeof(NSObject))]
	interface MNAVChapterReader
	{
		// +(NSArray *)chaptersFromAsset:(AVAsset *)asset;
		[Static]
		[Export("chaptersFromAsset:")]
		MNAVChapter[] GetChapters(AVAsset asset);
	}

// @protocol MNAVChapterReader <NSObject>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	// [Protocol]
	// [BaseType(typeof(NSObject))]
	// interface MNAVChapterReader
	// {
	// 	// @required -(NSArray *)chaptersFromAsset:(AVAsset *)asset;
	// 	[Abstract]
	// 	[Export("chaptersFromAsset:")]
	// 	MNAVChapter[] ChaptersFromAsset(AVAsset asset);
	// }

// // @interface MNAVChapterReaderMP3 : NSObject <MNAVChapterReader>
// 	[BaseType(typeof(NSObject))]
// 	interface MNAVChapterReaderMP3 : IMNAVChapterReader
// 	{
// 		// -(MNAVChapter *)chapterFromFrame:(NSData *)data;
// 		[Export("chapterFromFrame:")]
// 		MNAVChapter ChapterFromFrame(NSData data);
// 	}
//
// // @interface MNAVChapterReaderMP4 : NSObject <MNAVChapterReader>
// 	[BaseType(typeof(NSObject))]
// 	interface MNAVChapterReaderMP4 : IMNAVChapterReader
// 	{
// 	}

}