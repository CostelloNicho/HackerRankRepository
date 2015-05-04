//
//  main.swift
//  UtopianTree
//
//  Created by Syntinel on 4/23/15.
//  Copyright (c) 2015 CostelloNicho. All rights reserved.
//

import Foundation

//Get user input and make it into a string
let stdin = NSFileHandle.fileHandleWithStandardInput();
let inputString = NSString(data: stdin.availableData, encoding: NSUTF8StringEncoding)

//Parse the test case amount from this
var testCases = inputString?.integerValue;

//For each test case
for (var i = 0; i < testCases; i++){
    
    //Get the current cycle of the tree
    let cycleInput = NSFileHandle.fileHandleWithStandardInput();
    let cycleStr = NSString(data: cycleInput.availableData, encoding: NSUTF8StringEncoding)
    var cycleInt = cycleStr?.integerValue;
    
    //Calculate and print the height of the tree
    var height:Int = 0;
    for(var j = 0; j <= cycleInt; j++){
        height += j % 2 == 0 ? 1 : height;
    }
    println(height);
}



