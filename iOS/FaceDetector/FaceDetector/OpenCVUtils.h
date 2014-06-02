//
//  OpenCVUtils.h
//  FaceDetector
//
//  Created by Tri Nguyen on 6/2/14.
//  Copyright (c) 2014 Tri Nguyen. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface OpenCVUtils : NSObject
+ (cv::Mat)cvMatFromUIImage:(UIImage *)image;
+ (UIImage *)UIImageFromCVMat:(cv::Mat)cvMat;
+ (CGRect) cgRectFromCVRect:(cv::Rect) cvRect;
@end
