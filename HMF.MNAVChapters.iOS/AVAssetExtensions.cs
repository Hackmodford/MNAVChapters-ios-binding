using System;
using AVFoundation;
using MNAVChaptersAbstractions;

namespace HMF.MNAVChapters.iOS
{
	public static class AVAssetExtensions
	{
		public static MNAVChapter[] GetChapters(this AVAsset asset)
		{
			return MNAVChapterReader.GetChapters(asset);
		}
	}
}
