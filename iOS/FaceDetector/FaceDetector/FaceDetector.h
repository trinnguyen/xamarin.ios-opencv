//
//  FaceDetector.h
//  FaceDetector
//
//  Created by Tri Nguyen on 6/2/14.
//  Copyright (c) 2014 Tri Nguyen. All rights reserved.
//

@interface FaceDetector : NSObject
- (id) initWithFaceCascade:(NSString*) filePath;
- (NSArray*) detectFaces:(UIImage*) image;
@end
