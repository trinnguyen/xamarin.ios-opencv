//
//  FaceDetector.m
//  FaceDetector
//
//  Created by Tri Nguyen on 6/2/14.
//  Copyright (c) 2014 Tri Nguyen. All rights reserved.
//

#import "FaceDetector.h"
#import "OpenCVUtils.h"

@interface FaceDetector()   {
    cv::CascadeClassifier _faceCascade;
}

@end

@implementation FaceDetector
- (id) initWithFaceCascade:(NSString*) filePath {
    self = [super init];
    if (self)   {
        _faceCascade = cv::CascadeClassifier([filePath UTF8String]);
    }
    return self;
}
- (NSArray*) detectFaces:(UIImage*) image   {
    //detect faces with C code
    std::vector<cv::Rect> faces;
    cv::Mat matImage = [OpenCVUtils cvMatFromUIImage:image];
    cv::Size minSize = cv::Size(60, 60);
    _faceCascade.detectMultiScale(matImage, faces, 1.1, 2, CV_HAAR_FIND_BIGGEST_OBJECT | CV_HAAR_DO_ROUGH_SEARCH, minSize);
    
    //convert cv::vector<cv::Rect> to NSArray of CGRect
    NSMutableArray *arrFaces = [[NSMutableArray alloc] init];
    
    for(std::vector<cv::Rect>::iterator it = faces.begin(); it != faces.end(); ++it) {
        CGRect rect = [OpenCVUtils cgRectFromCVRect:*it];
        NSValue *value = [NSValue valueWithCGRect:rect];
        [arrFaces addObject:value];
    }
    
    return arrFaces;
}

@end
