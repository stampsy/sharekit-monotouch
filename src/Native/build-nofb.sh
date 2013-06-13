#!/bin/sh

BUILDDIR=build
PROJNAME=ShareKit

PROJDIR=$PROJNAME
MTPROJDIR=../$PROJNAME
PROJ=$PROJNAME-NoFB.xcodeproj

echo "==== Building for iOS devices ===="
echo ""
xcodebuild -project $PROJDIR/$PROJ

echo "==== Building for iOS simulator ===="
echo ""
xcodebuild -project $PROJDIR/$PROJ -sdk iphonesimulator

mkdir -p $BUILDDIR

cp $PROJDIR/build/Release-iphonesimulator/lib$PROJNAME.a $BUILDDIR/lib$PROJNAME-i386.a
cp $PROJDIR/build/Release-iphoneos/lib$PROJNAME.a $BUILDDIR/lib$PROJNAME-armv7.a

echo "Creating fat binary"
lipo -create $BUILDDIR/lib$PROJNAME-i386.a $BUILDDIR/lib$PROJNAME-armv7.a -output $BUILDDIR/lib$PROJNAME.a

cp $BUILDDIR/lib$PROJNAME.a $MTPROJDIR/lib$PROJNAME.a

echo "Done! ShareKit iOS Lib built: $PROJNAME"
