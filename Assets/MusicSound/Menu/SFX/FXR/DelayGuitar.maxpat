{
	"patcher" : 	{
		"fileversion" : 1,
		"appversion" : 		{
			"major" : 7,
			"minor" : 0,
			"revision" : 6,
			"architecture" : "x64",
			"modernui" : 1
		}
,
		"rect" : [ 26.0, 85.0, 1468.0, 713.0 ],
		"bglocked" : 0,
		"openinpresentation" : 0,
		"default_fontsize" : 12.0,
		"default_fontface" : 0,
		"default_fontname" : "Arial",
		"gridonopen" : 1,
		"gridsize" : [ 15.0, 15.0 ],
		"gridsnaponopen" : 1,
		"objectsnaponopen" : 1,
		"statusbarvisible" : 2,
		"toolbarvisible" : 1,
		"lefttoolbarpinned" : 0,
		"toptoolbarpinned" : 0,
		"righttoolbarpinned" : 0,
		"bottomtoolbarpinned" : 0,
		"toolbars_unpinned_last_save" : 0,
		"tallnewobj" : 0,
		"boxanimatetime" : 200,
		"enablehscroll" : 1,
		"enablevscroll" : 1,
		"devicewidth" : 0.0,
		"description" : "",
		"digest" : "",
		"tags" : "",
		"style" : "",
		"subpatcher_template" : "",
		"boxes" : [ 			{
				"box" : 				{
					"id" : "obj-31",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 757.0, 279.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "5"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-28",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 713.0, 279.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "4"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-26",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 674.0, 279.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "3"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-25",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 626.75, 279.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "2"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-23",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 586.0, 279.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "1"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-16",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 6,
					"outlettype" : [ "bang", "bang", "bang", "bang", "bang", "" ],
					"patching_rect" : [ 594.5, 227.899994, 109.0, 22.0 ],
					"style" : "",
					"text" : "sel 49 50 51 52 53"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-15",
					"maxclass" : "preset",
					"numinlets" : 1,
					"numoutlets" : 4,
					"outlettype" : [ "preset", "int", "preset", "int" ],
					"patching_rect" : [ 586.0, 324.0, 100.0, 40.0 ],
					"preset_data" : [ 						{
							"number" : 1,
							"data" : [ 5, "obj-5", "dial", "float", 0.481482, 5, "obj-8", "dial", "float", 0.025316, 5, "obj-9", "dial", "float", 12.345679, 5, "obj-10", "dial", "float", 0.075949, 5, "obj-13", "dial", "float", 12.34568, 5, "obj-14", "dial", "float", 76.0, 5, "obj-45", "flonum", "float", 0.025316, 5, "obj-46", "flonum", "float", 0.075949, 5, "obj-47", "flonum", "float", 17.34568, 5, "obj-49", "flonum", "float", 418.580261, 5, "obj-56", "flonum", "float", 0.6 ]
						}
, 						{
							"number" : 2,
							"data" : [ 5, "obj-5", "dial", "float", 0.481482, 5, "obj-8", "dial", "float", 0.329114, 5, "obj-9", "dial", "float", 37.037037, 5, "obj-10", "dial", "float", 0.253165, 5, "obj-13", "dial", "float", 49.382717, 5, "obj-14", "dial", "float", 76.0, 5, "obj-45", "flonum", "float", 0.329114, 5, "obj-46", "flonum", "float", 0.253165, 5, "obj-47", "flonum", "float", 54.382717, 5, "obj-49", "flonum", "float", 42.037037, 5, "obj-56", "flonum", "float", 0.6 ]
						}
, 						{
							"number" : 3,
							"data" : [ 5, "obj-5", "dial", "float", 0.481482, 5, "obj-8", "dial", "float", 0.556962, 5, "obj-9", "dial", "float", 37.037037, 5, "obj-10", "dial", "float", 0.683544, 5, "obj-13", "dial", "float", 98.765434, 5, "obj-14", "dial", "float", 76.0, 5, "obj-45", "flonum", "float", 0.556962, 5, "obj-46", "flonum", "float", 0.683544, 5, "obj-47", "flonum", "float", 103.765434, 5, "obj-49", "flonum", "float", 42.037037, 5, "obj-56", "flonum", "float", 0.6 ]
						}
, 						{
							"number" : 4,
							"data" : [ 5, "obj-5", "dial", "float", 0.481482, 5, "obj-8", "dial", "float", 0.936709, 5, "obj-9", "dial", "float", 37.037037, 5, "obj-10", "dial", "float", 0.987342, 5, "obj-13", "dial", "float", 98.765434, 5, "obj-14", "dial", "float", 76.0, 5, "obj-45", "flonum", "float", 0.936709, 5, "obj-46", "flonum", "float", 0.987342, 5, "obj-47", "flonum", "float", 103.765434, 5, "obj-49", "flonum", "float", 42.037037, 5, "obj-56", "flonum", "float", 0.6 ]
						}
 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "",
					"id" : "obj-18",
					"maxclass" : "inlet",
					"numinlets" : 0,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 594.5, 190.399994, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 90.0,
					"id" : "obj-1",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 2.724991, 10.400002, 528.0, 96.0 ],
					"style" : "",
					"text" : "DEEPSPACE"
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Area 51 UFO Alien Greeting",
					"fontsize" : 64.0,
					"id" : "obj-19",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 279.350006, 94.399994, 180.0, 76.0 ],
					"style" : "",
					"text" : "Delay",
					"textcolor" : [ 0.239216, 0.254902, 0.278431, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 90.0,
					"id" : "obj-7",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 16.224991, 10.400002, 528.0, 96.0 ],
					"style" : "",
					"text" : "DEEPSPACE",
					"textcolor" : [ 0.239216, 0.254902, 0.278431, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-12",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 422.099976, 179.399994, 99.0, 26.0 ],
					"style" : "",
					"text" : "Main Vol"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-17",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 324.475006, 179.399994, 99.0, 26.0 ],
					"style" : "",
					"text" : "Dry/Wet"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-20",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 237.074982, 179.399994, 80.0, 26.0 ],
					"style" : "",
					"text" : "R Feed"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-21",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 84.600006, 179.399994, 79.0, 26.0 ],
					"style" : "",
					"text" : "L Feed"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-33",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 156.574982, 179.399994, 91.0, 26.0 ],
					"style" : "",
					"text" : "R Delay "
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-34",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 2.724991, 179.399994, 96.0, 26.0 ],
					"style" : "",
					"text" : "L Delay "
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"htricolor" : [ 0.92549, 0.364706, 0.341176, 1.0 ],
					"id" : "obj-56",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 442.849976, 246.899994, 42.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"tricolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"htricolor" : [ 0.92549, 0.364706, 0.341176, 1.0 ],
					"id" : "obj-49",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 18.224991, 246.899994, 42.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"tricolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"htricolor" : [ 0.92549, 0.364706, 0.341176, 1.0 ],
					"id" : "obj-47",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 168.725006, 246.899994, 41.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"tricolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"htricolor" : [ 0.92549, 0.364706, 0.341176, 1.0 ],
					"id" : "obj-46",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 251.574982, 246.899994, 40.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"tricolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"htricolor" : [ 0.92549, 0.364706, 0.341176, 1.0 ],
					"id" : "obj-45",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 99.850006, 246.899994, 41.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"tricolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-40",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 422.099976, 179.399994, 99.0, 26.0 ],
					"style" : "",
					"text" : "Main Vol"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-37",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 324.475006, 179.399994, 99.0, 26.0 ],
					"style" : "",
					"text" : "Dry/Wet"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-30",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 237.074982, 179.399994, 80.0, 26.0 ],
					"style" : "",
					"text" : "R Feed"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-29",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 84.600006, 179.399994, 79.0, 26.0 ],
					"style" : "",
					"text" : "L Feed"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-27",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 156.574982, 179.399994, 91.0, 26.0 ],
					"style" : "",
					"text" : "R Delay "
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 20.0,
					"id" : "obj-24",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 2.724991, 179.399994, 96.0, 26.0 ],
					"style" : "",
					"text" : "L Delay "
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"id" : "obj-14",
					"maxclass" : "dial",
					"needlecolor" : [ 0.32549, 0.345098, 0.372549, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 341.099976, 209.399994, 40.5, 40.5 ],
					"size" : 101.0,
					"style" : "",
					"varname" : "Dry/Wet"
				}

			}
, 			{
				"box" : 				{
					"annotation" : "",
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"floatoutput" : 1,
					"id" : "obj-13",
					"maxclass" : "dial",
					"min" : 5.0,
					"needlecolor" : [ 0.32549, 0.345098, 0.372549, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 166.725006, 209.399994, 40.5, 40.5 ],
					"size" : 500.0,
					"style" : "",
					"varname" : "RightDelay"
				}

			}
, 			{
				"box" : 				{
					"annotation" : "",
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"floatoutput" : 1,
					"id" : "obj-10",
					"maxclass" : "dial",
					"needlecolor" : [ 0.32549, 0.345098, 0.372549, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 249.574982, 209.399994, 39.5, 39.5 ],
					"size" : 1.0,
					"style" : "",
					"varname" : "RightFeed"
				}

			}
, 			{
				"box" : 				{
					"annotation" : "",
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"floatoutput" : 1,
					"id" : "obj-9",
					"maxclass" : "dial",
					"min" : 5.0,
					"needlecolor" : [ 0.32549, 0.345098, 0.372549, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 16.224991, 209.399994, 40.5, 40.5 ],
					"size" : 500.0,
					"style" : "",
					"varname" : "LeftDelay"
				}

			}
, 			{
				"box" : 				{
					"annotation" : "",
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"floatoutput" : 1,
					"id" : "obj-8",
					"maxclass" : "dial",
					"needlecolor" : [ 0.32549, 0.345098, 0.372549, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 97.850006, 209.399994, 39.5, 39.5 ],
					"size" : 1.0,
					"style" : "",
					"varname" : "LeftFeed"
				}

			}
, 			{
				"box" : 				{
					"annotation" : "",
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"floatoutput" : 1,
					"id" : "obj-5",
					"maxclass" : "dial",
					"needlecolor" : [ 0.32549, 0.345098, 0.372549, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 440.849976, 209.399994, 40.5, 40.5 ],
					"size" : 5.0,
					"style" : "",
					"varname" : "Vol"
				}

			}
, 			{
				"box" : 				{
					"angle" : 270.0,
					"bordercolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"grad1" : [ 0.0, 0.0, 0.0, 1.0 ],
					"grad2" : [ 0.239216, 0.254902, 0.278431, 1.0 ],
					"id" : "obj-55",
					"maxclass" : "panel",
					"mode" : 1,
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ -0.306259, -2.099998, 534.0625, 293.0 ],
					"proportion" : 0.698068,
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-6",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 36.037491, 239.399994, 29.5, 22.0 ],
					"style" : "",
					"text" : "+ 1"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-41",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 1.224991, 218.399994, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-38",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"patching_rect" : [ 3.224991, 239.399994, 31.0, 22.0 ],
					"style" : "",
					"text" : "+ 0."
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Area 51 UFO Apocalypse",
					"fontsize" : 64.0,
					"id" : "obj-11",
					"maxclass" : "newobj",
					"numinlets" : 8,
					"numoutlets" : 2,
					"outlettype" : [ "signal", "signal" ],
					"patching_rect" : [ 43.074982, 108.400002, 275.0, 72.0 ],
					"style" : "",
					"text" : "FXDelay",
					"textcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"comment" : "",
					"id" : "obj-4",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 228.100006, 209.399994, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "",
					"id" : "obj-3",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 165.574982, 209.399994, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "",
					"id" : "obj-2",
					"maxclass" : "inlet",
					"numinlets" : 0,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 91.683334, 69.399994, 30.0, 30.0 ],
					"style" : ""
				}

			}
 ],
		"lines" : [ 			{
				"patchline" : 				{
					"destination" : [ "obj-46", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-10", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-3", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-11", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-4", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-11", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-47", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-13", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-14", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-23", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-16", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-25", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-16", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-26", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-16", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-28", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-16", 3 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-31", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-16", 4 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-16", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-18", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 2 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-2", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-2", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-15", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-23", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-15", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-25", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-15", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-26", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-15", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-15", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-31", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-38", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-41", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 4 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-45", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 7 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-46", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 6 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-47", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 3 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-49", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-56", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-5", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 5 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-56", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-45", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-8", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-49", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-9", 0 ]
				}

			}
 ],
		"styles" : [ 			{
				"name" : "newobjBlue-1",
				"default" : 				{
					"accentcolor" : [ 0.317647, 0.654902, 0.976471, 1.0 ]
				}
,
				"parentstyle" : "",
				"multi" : 0
			}
, 			{
				"name" : "newobjYellow-1",
				"default" : 				{
					"accentcolor" : [ 0.82517, 0.78181, 0.059545, 1.0 ],
					"fontsize" : [ 12.059008 ]
				}
,
				"parentstyle" : "",
				"multi" : 0
			}
, 			{
				"name" : "numberGold-1",
				"default" : 				{
					"accentcolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}
,
				"parentstyle" : "",
				"multi" : 0
			}
, 			{
				"name" : "sliderGold-1",
				"default" : 				{
					"color" : [ 0.907107, 0.934609, 0.842715, 1.0 ],
					"accentcolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}
,
				"parentstyle" : "",
				"multi" : 0
			}
 ]
	}

}
