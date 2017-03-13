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
		"rect" : [ 42.0, 123.0, 1084.0, 707.0 ],
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
					"id" : "obj-85",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 405.0, 100.0, 150.0, 20.0 ],
					"style" : "",
					"text" : "For Midi-->",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-84",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 405.0, 82.5, 150.0, 20.0 ],
					"style" : "",
					"text" : "For Freq-->",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-66",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 0.0, 0.0, 150.0, 20.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"blackkeycolor" : [ 0.0, 0.0, 0.0, 1.0 ],
					"hkeycolor" : [ 0.741176, 0.356863, 0.047059, 1.0 ],
					"id" : "obj-13",
					"maxclass" : "kslider",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "int", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 70.5, 7.5, 392.0, 60.0 ],
					"presentation_rect" : [ 0.0, 0.0, 336.0, 53.0 ],
					"selectioncolor" : [ 0.439216, 0.74902, 0.254902, 1.0 ],
					"style" : "",
					"whitekeycolor" : [ 1.0, 1.0, 1.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"htricolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"id" : "obj-88",
					"maxclass" : "number",
					"maximum" : 10,
					"minimum" : 1,
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 89.0625, 107.0, 37.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-87",
					"linecount" : 2,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 75.875, 74.5, 47.25, 34.0 ],
					"style" : "",
					"text" : "# of Voices",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-83",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 6.5, 132.0, 150.0, 20.0 ],
					"style" : "",
					"text" : "Direction",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgfillcolor_angle" : 270.0,
					"bgfillcolor_autogradient" : 0,
					"bgfillcolor_color" : [ 0.290196, 0.309804, 0.301961, 1.0 ],
					"bgfillcolor_color1" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"bgfillcolor_color2" : [ 0.043137, 0.364706, 0.094118, 1.0 ],
					"bgfillcolor_proportion" : 0.39,
					"bgfillcolor_type" : "gradient",
					"color" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"elementcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"id" : "obj-79",
					"items" : [ "Up", ",", "Down", ",", "Up/Down" ],
					"maxclass" : "umenu",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 9.0, 151.5, 53.5, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 10.0,
					"id" : "obj-67",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 473.5, 62.0, 235.0, 18.0 ],
					"style" : "",
					"text" : "Keycodes: 1 Maj 2 Min 3 Aug 4 Dim 5 Maj7 6 Min7",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-29",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 9.0, 217.75, 38.0, 38.0 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Star Jedi Rounded",
					"fontsize" : 48.0,
					"id" : "obj-107",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 129.5, 68.0, 257.0, 83.0 ],
					"style" : "",
					"text" : "venusian",
					"textcolor" : [ 0.043137, 0.364706, 0.094118, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Star Jedi Rounded",
					"fontsize" : 48.0,
					"id" : "obj-103",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 124.5, 64.0, 257.0, 83.0 ],
					"style" : "",
					"text" : "venusian",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Star Jedi Rounded",
					"fontsize" : 48.0,
					"id" : "obj-106",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 252.0, 110.5, 235.0, 83.0 ],
					"style" : "",
					"text" : "voicer",
					"textcolor" : [ 0.043137, 0.364706, 0.094118, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Star Jedi Rounded",
					"fontsize" : 48.0,
					"id" : "obj-105",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 245.0, 107.0, 235.0, 83.0 ],
					"style" : "",
					"text" : "voicer",
					"textcolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"active1" : [ 0.741176, 0.356863, 0.047059, 1.0 ],
					"bgcolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"emptycolor" : [ 0.043137, 0.364706, 0.094118, 1.0 ],
					"id" : "obj-55",
					"maxclass" : "preset",
					"numinlets" : 1,
					"numoutlets" : 4,
					"outlettype" : [ "preset", "int", "preset", "int" ],
					"patching_rect" : [ 473.5, 82.5, 222.75, 80.5 ],
					"preset_data" : [ 						{
							"number" : 1,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 66.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 0, 5, "obj-17", "number", "int", 0, 5, "obj-102", "flonum", "float", 66.0, 5, "obj-53", "flonum", "float", 4.0, 5, "obj-58", "number", "int", 66, 5, "obj-38", "toggle", "int", 0, 5, "obj-54", "tab", "int", 5, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 184.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 0, 5, "obj-33", "toggle", "int", 1, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 220.0, 5, "obj-43", "flonum", "float", 277.0, 5, "obj-42", "flonum", "float", 329.0, 5, "obj-47", "flonum", "float", 0.0, 5, "obj-46", "flonum", "float", 440.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 659.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 1318.0, 5, "obj-92", "dial", "float", 175.0, 5, "obj-94", "number", "int", 175, 5, "obj-22", "flonum", "float", 0.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 54 ]
						}
, 						{
							"number" : 2,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 84.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 0, 5, "obj-17", "number", "int", 0, 5, "obj-102", "flonum", "float", 84.0, 5, "obj-53", "flonum", "float", 6.0, 5, "obj-58", "number", "int", 84, 5, "obj-38", "toggle", "int", 0, 5, "obj-54", "tab", "int", 0, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 246.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 0, 5, "obj-33", "toggle", "int", 1, 5, "obj-36", "toggle", "int", 1, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 311.0, 5, "obj-43", "flonum", "float", 369.0, 5, "obj-42", "flonum", "float", 493.0, 5, "obj-47", "flonum", "float", 0.0, 5, "obj-46", "flonum", "float", 739.0, 5, "obj-45", "flonum", "float", 987.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 1479.0, 5, "obj-50", "flonum", "float", 1975.0, 5, "obj-92", "dial", "float", 316.0, 5, "obj-94", "number", "int", 316, 5, "obj-22", "flonum", "float", 0.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 59 ]
						}
, 						{
							"number" : 3,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 67.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 0, 5, "obj-17", "number", "int", 0, 5, "obj-102", "flonum", "float", 67.0, 5, "obj-53", "flonum", "float", 4.0, 5, "obj-58", "number", "int", 67, 5, "obj-38", "toggle", "int", 0, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 164.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 1, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 207.0, 5, "obj-43", "flonum", "float", 246.0, 5, "obj-42", "flonum", "float", 311.0, 5, "obj-47", "flonum", "float", 329.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 493.0, 5, "obj-44", "flonum", "float", 622.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 1244.0, 5, "obj-92", "dial", "float", 105.0, 5, "obj-94", "number", "int", 105, 5, "obj-22", "flonum", "float", 0.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 52 ]
						}
, 						{
							"number" : 4,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 68.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 0, 5, "obj-17", "number", "int", 0, 5, "obj-102", "flonum", "float", 68.0, 5, "obj-53", "flonum", "float", 3.0, 5, "obj-58", "number", "int", 68, 5, "obj-38", "toggle", "int", 0, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 220.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 277.0, 5, "obj-43", "flonum", "float", 329.0, 5, "obj-42", "flonum", "float", 415.0, 5, "obj-47", "flonum", "float", 440.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 830.0, 5, "obj-51", "flonum", "float", 879.0, 5, "obj-50", "flonum", "float", 1661.0, 5, "obj-92", "dial", "float", 421.0, 5, "obj-94", "number", "int", 421, 5, "obj-22", "flonum", "float", 0.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 57 ]
						}
, 						{
							"number" : 5,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 68.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 0, 5, "obj-17", "number", "int", 0, 5, "obj-102", "flonum", "float", 68.0, 5, "obj-53", "flonum", "float", 3.0, 5, "obj-58", "number", "int", 68, 5, "obj-38", "toggle", "int", 0, 5, "obj-54", "tab", "int", 0, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 246.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 311.0, 5, "obj-43", "flonum", "float", 369.0, 5, "obj-42", "flonum", "float", 493.0, 5, "obj-47", "flonum", "float", 622.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 1244.0, 5, "obj-51", "flonum", "float", 1479.0, 5, "obj-50", "flonum", "float", 1975.0, 5, "obj-92", "dial", "float", 421.0, 5, "obj-94", "number", "int", 421, 5, "obj-22", "flonum", "float", 0.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 59 ]
						}
, 						{
							"number" : 6,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 80.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 830, 5, "obj-102", "flonum", "float", 80.0, 5, "obj-53", "flonum", "float", 5.0, 5, "obj-58", "number", "int", 80, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 329.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 1, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 415.0, 5, "obj-43", "flonum", "float", 493.0, 5, "obj-42", "flonum", "float", 622.0, 5, "obj-47", "flonum", "float", 659.0, 5, "obj-46", "flonum", "float", 830.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 1244.0, 5, "obj-51", "flonum", "float", 1318.0, 5, "obj-50", "flonum", "float", 2489.0, 5, "obj-92", "dial", "float", 35.0, 5, "obj-94", "number", "int", 35, 5, "obj-22", "flonum", "float", 830.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 64 ]
						}
, 						{
							"number" : 7,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 76.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 659, 5, "obj-102", "flonum", "float", 76.0, 5, "obj-53", "flonum", "float", 5.0, 5, "obj-58", "number", "int", 76, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 261.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 1, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 329.0, 5, "obj-43", "flonum", "float", 391.0, 5, "obj-42", "flonum", "float", 493.0, 5, "obj-47", "flonum", "float", 523.0, 5, "obj-46", "flonum", "float", 659.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 987.0, 5, "obj-51", "flonum", "float", 1046.0, 5, "obj-50", "flonum", "float", 1975.0, 5, "obj-92", "dial", "float", 35.0, 5, "obj-94", "number", "int", 35, 5, "obj-22", "flonum", "float", 659.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 60 ]
						}
, 						{
							"number" : 8,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 88.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 1318, 5, "obj-102", "flonum", "float", 88.0, 5, "obj-53", "flonum", "float", 7.0, 5, "obj-58", "number", "int", 88, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 0, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 261.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 0, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 1, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 329.0, 5, "obj-43", "flonum", "float", 391.0, 5, "obj-42", "flonum", "float", 0.0, 5, "obj-47", "flonum", "float", 659.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 1046.0, 5, "obj-44", "flonum", "float", 1318.0, 5, "obj-51", "flonum", "float", 1567.0, 5, "obj-50", "flonum", "float", 2093.0, 5, "obj-92", "dial", "float", 282.0, 5, "obj-94", "number", "int", 282, 5, "obj-22", "flonum", "float", 1318.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-13", "kslider", "int", 60, 5, "obj-79", "umenu", "int", 2, 5, "obj-88", "number", "int", 8 ]
						}
, 						{
							"number" : 9,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 68.0, 5, "obj-14", "gswitch2", "int", 1, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 415, 5, "obj-102", "flonum", "float", 68.0, 5, "obj-53", "flonum", "float", 2.0, 5, "obj-58", "number", "int", 68, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 2, 5, "obj-21", "tab", "int", 1, 5, "obj-23", "flonum", "float", 261.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 0, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 1, 5, "obj-36", "toggle", "int", 1, 5, "obj-35", "toggle", "int", 1, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 329.0, 5, "obj-43", "flonum", "float", 415.0, 5, "obj-42", "flonum", "float", 0.0, 5, "obj-47", "flonum", "float", 659.0, 5, "obj-46", "flonum", "float", 830.0, 5, "obj-45", "flonum", "float", 1046.0, 5, "obj-44", "flonum", "float", 1318.0, 5, "obj-51", "flonum", "float", 1661.0, 5, "obj-50", "flonum", "float", 2093.0, 5, "obj-92", "dial", "float", 106.0, 5, "obj-94", "number", "int", 106, 5, "obj-22", "flonum", "float", 415.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-13", "kslider", "int", 60, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8 ]
						}
, 						{
							"number" : 19,
							"data" : [ 5, "obj-37", "number", "int", 32, 5, "obj-61", "flonum", "float", 71.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 71, 5, "obj-102", "flonum", "float", 71.0, 5, "obj-53", "flonum", "float", 3.0, 5, "obj-58", "number", "int", 71, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 60.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 0, 5, "obj-33", "toggle", "int", 1, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 0, 5, "obj-41", "flonum", "float", 64.0, 5, "obj-43", "flonum", "float", 67.0, 5, "obj-42", "flonum", "float", 71.0, 5, "obj-47", "flonum", "float", 0.0, 5, "obj-46", "flonum", "float", 76.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 0.0, 5, "obj-92", "dial", "float", 175.0, 5, "obj-94", "number", "int", 175, 5, "obj-22", "flonum", "float", 71.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 0, 5, "obj-88", "number", "int", 4, 5, "obj-13", "kslider", "int", 60 ]
						}
, 						{
							"number" : 20,
							"data" : [ 5, "obj-37", "number", "int", 0, 5, "obj-61", "flonum", "float", 65.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 65, 5, "obj-102", "flonum", "float", 65.0, 5, "obj-53", "flonum", "float", 0.0, 5, "obj-58", "number", "int", 65, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 65.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 0, 5, "obj-33", "toggle", "int", 1, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 0, 5, "obj-41", "flonum", "float", 69.0, 5, "obj-43", "flonum", "float", 72.0, 5, "obj-42", "flonum", "float", 76.0, 5, "obj-47", "flonum", "float", 0.0, 5, "obj-46", "flonum", "float", 81.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 0.0, 5, "obj-92", "dial", "float", 316.0, 5, "obj-94", "number", "int", 316, 5, "obj-22", "flonum", "float", 65.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 0, 5, "obj-88", "number", "int", 4, 5, "obj-13", "kslider", "int", 65 ]
						}
, 						{
							"number" : 21,
							"data" : [ 5, "obj-37", "number", "int", 0, 5, "obj-61", "flonum", "float", 65.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 65, 5, "obj-102", "flonum", "float", 65.0, 5, "obj-53", "flonum", "float", 0.0, 5, "obj-58", "number", "int", 65, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 3, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 65.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 68.0, 5, "obj-43", "flonum", "float", 71.0, 5, "obj-42", "flonum", "float", 77.0, 5, "obj-47", "flonum", "float", 80.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 101.0, 5, "obj-92", "dial", "float", 105.0, 5, "obj-94", "number", "int", 105, 5, "obj-22", "flonum", "float", 65.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 0, 5, "obj-88", "number", "int", 4, 5, "obj-13", "kslider", "int", 65 ]
						}
, 						{
							"number" : 22,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 76.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 76, 5, "obj-102", "flonum", "float", 76.0, 5, "obj-53", "flonum", "float", 3.0, 5, "obj-58", "number", "int", 76, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 65.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 0, 5, "obj-41", "flonum", "float", 69.0, 5, "obj-43", "flonum", "float", 72.0, 5, "obj-42", "flonum", "float", 76.0, 5, "obj-47", "flonum", "float", 77.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 0.0, 5, "obj-92", "dial", "float", 421.0, 5, "obj-94", "number", "int", 421, 5, "obj-22", "flonum", "float", 76.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 65 ]
						}
, 						{
							"number" : 23,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 76.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 76, 5, "obj-102", "flonum", "float", 76.0, 5, "obj-53", "flonum", "float", 4.0, 5, "obj-58", "number", "int", 76, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 5, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 64.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 0, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 0, 5, "obj-41", "flonum", "float", 67.0, 5, "obj-43", "flonum", "float", 71.0, 5, "obj-42", "flonum", "float", 74.0, 5, "obj-47", "flonum", "float", 0.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 0.0, 5, "obj-92", "dial", "float", 526.0, 5, "obj-94", "number", "int", 526, 5, "obj-22", "flonum", "float", 76.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 64 ]
						}
, 						{
							"number" : 24,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 84.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 84, 5, "obj-102", "flonum", "float", 84.0, 5, "obj-53", "flonum", "float", 7.0, 5, "obj-58", "number", "int", 84, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 5, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 62.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 0, 5, "obj-41", "flonum", "float", 65.0, 5, "obj-43", "flonum", "float", 69.0, 5, "obj-42", "flonum", "float", 72.0, 5, "obj-47", "flonum", "float", 74.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 0.0, 5, "obj-92", "dial", "float", 35.0, 5, "obj-94", "number", "int", 35, 5, "obj-22", "flonum", "float", 84.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 62 ]
						}
, 						{
							"number" : 25,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 83.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 83, 5, "obj-102", "flonum", "float", 83.0, 5, "obj-53", "flonum", "float", 7.0, 5, "obj-58", "number", "int", 83, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 4, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 60.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 1, 5, "obj-34", "toggle", "int", 0, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 1, 5, "obj-39", "toggle", "int", 1, 5, "obj-41", "flonum", "float", 64.0, 5, "obj-43", "flonum", "float", 67.0, 5, "obj-42", "flonum", "float", 71.0, 5, "obj-47", "flonum", "float", 0.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 84.0, 5, "obj-50", "flonum", "float", 95.0, 5, "obj-92", "dial", "float", 35.0, 5, "obj-94", "number", "int", 35, 5, "obj-22", "flonum", "float", 83.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 60 ]
						}
, 						{
							"number" : 26,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 84.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 84, 5, "obj-102", "flonum", "float", 84.0, 5, "obj-53", "flonum", "float", 6.0, 5, "obj-58", "number", "int", 84, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 0, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 60.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 0, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 0, 5, "obj-41", "flonum", "float", 64.0, 5, "obj-43", "flonum", "float", 67.0, 5, "obj-42", "flonum", "float", 0.0, 5, "obj-47", "flonum", "float", 76.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 0.0, 5, "obj-92", "dial", "float", 282.0, 5, "obj-94", "number", "int", 282, 5, "obj-22", "flonum", "float", 84.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 2, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 60 ]
						}
, 						{
							"number" : 27,
							"data" : [ 5, "obj-37", "number", "int", 110, 5, "obj-61", "flonum", "float", 80.0, 5, "obj-14", "gswitch2", "int", 0, 5, "obj-19", "gswitch2", "int", 1, 5, "obj-17", "number", "int", 80, 5, "obj-102", "flonum", "float", 80.0, 5, "obj-53", "flonum", "float", 5.0, 5, "obj-58", "number", "int", 80, 5, "obj-38", "toggle", "int", 1, 5, "obj-54", "tab", "int", 2, 5, "obj-21", "tab", "int", 0, 5, "obj-23", "flonum", "float", 60.0, 5, "obj-30", "toggle", "int", 1, 5, "obj-32", "toggle", "int", 1, 5, "obj-31", "toggle", "int", 0, 5, "obj-34", "toggle", "int", 1, 5, "obj-33", "toggle", "int", 0, 5, "obj-36", "toggle", "int", 0, 5, "obj-35", "toggle", "int", 0, 5, "obj-40", "toggle", "int", 0, 5, "obj-39", "toggle", "int", 0, 5, "obj-41", "flonum", "float", 64.0, 5, "obj-43", "flonum", "float", 68.0, 5, "obj-42", "flonum", "float", 0.0, 5, "obj-47", "flonum", "float", 76.0, 5, "obj-46", "flonum", "float", 0.0, 5, "obj-45", "flonum", "float", 0.0, 5, "obj-44", "flonum", "float", 0.0, 5, "obj-51", "flonum", "float", 0.0, 5, "obj-50", "flonum", "float", 0.0, 5, "obj-92", "dial", "float", 106.0, 5, "obj-94", "number", "int", 106, 5, "obj-22", "flonum", "float", 80.0, 5, "obj-29", "toggle", "int", 1, 5, "obj-79", "umenu", "int", 1, 5, "obj-88", "number", "int", 8, 5, "obj-13", "kslider", "int", 60 ]
						}
 ],
					"stored1" : [ 0.741176, 0.356863, 0.047059, 1.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-22",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 9.0, 61.5, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-98",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 0.0, 82.5, 76.25, 20.0 ],
					"style" : "",
					"text" : "Speed [ms]",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"htricolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"id" : "obj-94",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 41.0, 107.0, 45.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"id" : "obj-92",
					"maxclass" : "dial",
					"needlecolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.741176, 0.356863, 0.047059, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 9.0, 104.5, 28.5, 28.5 ],
					"size" : 1000.0,
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 13.0,
					"id" : "obj-91",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 6.5, 1.0, 57.5, 21.0 ],
					"style" : "",
					"text" : "Arpeggi",
					"textcolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-50",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 589.0, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-51",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 524.5, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-44",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 463.0, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-45",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 405.0, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-46",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 339.5, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-47",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 273.25, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-42",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 205.0, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-43",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 141.0, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-41",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 81.25, 189.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-39",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 595.5, 221.0, 37.0, 37.0 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-40",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 530.5, 221.0, 38.0, 38.0 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-35",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 463.0, 221.0, 38.0, 38.0 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-36",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 403.5, 221.0, 38.0, 38.0 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-33",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 339.5, 221.0, 38.0, 38.0 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-34",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 273.25, 221.0, 36.5, 36.5 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-31",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 205.0, 221.0, 36.5, 36.5 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-32",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 141.0, 221.0, 36.5, 36.5 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-30",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 81.25, 221.0, 36.5, 36.5 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-23",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 9.0, 186.5, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"htabcolor" : [ 0.741176, 0.356863, 0.047059, 1.0 ],
					"id" : "obj-21",
					"maxclass" : "tab",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 644.25, 225.0, 61.0, 29.0 ],
					"style" : "",
					"tabcolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"tabs" : [ "Midi", "Freq" ],
					"textcolor" : [ 0.043137, 0.364706, 0.094118, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"htabcolor" : [ 0.741176, 0.356863, 0.047059, 1.0 ],
					"id" : "obj-54",
					"maxclass" : "tab",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 473.5, 16.0, 224.0, 43.0 ],
					"style" : "",
					"tabcolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"tabs" : [ "Maj", "Min", "Aug", "Dim", "Maj7", "Min7" ],
					"textcolor" : [ 0.043137, 0.364706, 0.094118, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"checkedcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-38",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 9.0, 16.0, 38.0, 38.0 ],
					"style" : "",
					"uncheckedcolor" : [ 0.0, 0.0, 0.0, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"angle" : 270.0,
					"grad1" : [ 0.043137, 0.364706, 0.094118, 1.0 ],
					"grad2" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-65",
					"maxclass" : "panel",
					"mode" : 1,
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ -7.0, -4.25, 717.0, 277.0 ],
					"proportion" : 0.39,
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-58",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 397.5, 100.0, 50.0, 22.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-27",
					"maxclass" : "newobj",
					"numinlets" : 21,
					"numoutlets" : 10,
					"outlettype" : [ "", "", "", "", "", "", "", "", "", "" ],
					"patching_rect" : [ 447.25, 141.0, 229.0, 22.0 ],
					"style" : "",
					"text" : "frequency"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-166",
					"maxclass" : "newobj",
					"numinlets" : 4,
					"numoutlets" : 11,
					"outlettype" : [ "", "", "", "", "", "", "", "", "", "", "" ],
					"patching_rect" : [ 374.0, 16.0, 97.0, 22.0 ],
					"style" : "",
					"text" : "gate-abstraction"
				}

			}
, 			{
				"box" : 				{
					"format" : 6,
					"id" : "obj-53",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 24.75, 199.0, 50.0, 22.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-2",
					"maxclass" : "newobj",
					"numinlets" : 5,
					"numoutlets" : 4,
					"outlettype" : [ "int", "", "", "int" ],
					"patching_rect" : [ 24.75, 169.25, 61.0, 22.0 ],
					"style" : "",
					"text" : "counter 9"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-1",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 11.25, 92.75, 65.0, 22.0 ],
					"style" : "",
					"text" : "metro 500"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-169",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 515.0, 100.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "+ 1"
				}

			}
, 			{
				"box" : 				{
					"comment" : "10",
					"id" : "obj-78",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 635.5, 146.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "9",
					"id" : "obj-77",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 570.5, 146.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "8",
					"id" : "obj-76",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 504.0, 146.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "7",
					"id" : "obj-75",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 443.5, 146.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "6",
					"id" : "obj-74",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 363.25, 146.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "5",
					"id" : "obj-73",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 678.25, 210.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "4",
					"id" : "obj-72",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 245.0, 146.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "3",
					"id" : "obj-71",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 215.0, 149.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "2",
					"id" : "obj-70",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 129.5, 151.5, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "1",
					"id" : "obj-69",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 81.25, 146.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-102",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 176.75, 74.5, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-82",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 57.5, 68.0, 56.0, 22.0 ],
					"style" : "",
					"text" : "delay 10"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-20",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 610.75, 107.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-17",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 636.25, 205.0, 50.0, 22.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-26",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 635.25, 132.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-104",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 630.0, 141.0, 41.0, 22.0 ],
					"style" : "",
					"text" : "$1 15"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-24",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"patching_rect" : [ 636.25, 181.0, 40.0, 22.0 ],
					"style" : "",
					"text" : "line"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-19",
					"int" : 1,
					"maxclass" : "gswitch2",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 635.25, 92.0, 39.0, 32.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-15",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 671.25, 68.0, 34.0, 22.0 ],
					"style" : "",
					"text" : "mtof"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-14",
					"int" : 1,
					"maxclass" : "gswitch2",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 635.25, 55.0, 39.0, 32.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.019608, 0.254902, 0.035294, 1.0 ],
					"format" : 6,
					"htricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ],
					"id" : "obj-61",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 655.25, 30.0, 50.0, 22.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.764706, 0.592157, 0.101961, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"comment" : "Arpeggiator",
					"id" : "obj-5",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1.75, 224.25, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-28",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 530.5, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-25",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 595.5, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-18",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 463.0, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-16",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 403.5, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-12",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 339.5, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-11",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 273.25, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-10",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 205.0, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-9",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 141.0, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-8",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 81.25, 221.0, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-7",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 6.5, 220.25, 24.0, 24.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-49",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 620.25, 168.0, 72.0, 22.0 ],
					"style" : "",
					"text" : "loadmess 0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-48",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 496.5, 40.0, 72.0, 22.0 ],
					"style" : "",
					"text" : "loadmess 0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-4",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 9.0, 185.25, 60.0, 22.0 ],
					"style" : "",
					"text" : "loadbang"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-6",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 636.25, 181.0, 60.0, 22.0 ],
					"style" : "",
					"text" : "loadbang"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-59",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 2,
					"outlettype" : [ "int", "int" ],
					"patching_rect" : [ 620.25, 119.0, 65.0, 22.0 ],
					"style" : "",
					"text" : "split 49 54"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-56",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 604.5, 146.0, 92.0, 22.0 ],
					"style" : "",
					"text" : "scale 49 54 0 5"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-37",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 620.25, 91.0, 50.0, 22.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-52",
					"maxclass" : "newobj",
					"numinlets" : 0,
					"numoutlets" : 4,
					"outlettype" : [ "int", "int", "int", "int" ],
					"patching_rect" : [ 620.25, 64.0, 50.5, 22.0 ],
					"style" : "",
					"text" : "key"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-89",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 66.75, 141.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "- 1"
				}

			}
, 			{
				"box" : 				{
					"comment" : "Midiin",
					"id" : "obj-60",
					"maxclass" : "inlet",
					"numinlets" : 0,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 66.75, 1.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-57",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "int", "int" ],
					"patching_rect" : [ 66.75, 38.0, 43.0, 22.0 ],
					"style" : "",
					"text" : "notein"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-62",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 70.5, 1.0, 79.0, 22.0 ],
					"style" : "",
					"text" : "loadmess 48"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-63",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 41.0, 74.5, 85.0, 22.0 ],
					"style" : "",
					"text" : "loadmess 500"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-64",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 81.25, 68.0, 72.0, 22.0 ],
					"style" : "",
					"text" : "loadmess 4"
				}

			}
, 			{
				"box" : 				{
					"comment" : "",
					"id" : "obj-3",
					"maxclass" : "inlet",
					"numinlets" : 0,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 671.25, 0.0, 30.0, 30.0 ],
					"style" : ""
				}

			}
 ],
		"lines" : [ 			{
				"patchline" : 				{
					"destination" : [ "obj-2", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-1", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-10", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-61", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-102", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-24", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-104", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-12", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-11", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-16", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-12", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-166", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-13", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-15", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-14", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-19", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-14", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-19", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-15", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-18", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-16", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 20 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 9 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 18 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 8 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 16 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 7 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 14 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 6 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 12 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 5 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 10 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 4 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 8 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 3 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 6 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 4 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 2 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-58", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-166", 10 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-166", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-169", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-22", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-17", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-28", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-18", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-104", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-19", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-26", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-19", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-53", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-2", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-26", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-20", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-14", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-21", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-21", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-5", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-22", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-69", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-23", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-17", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-24", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-166", 3 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-25", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-104", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-26", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-23", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-41", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-42", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 3 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-43", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-44", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 7 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-45", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 6 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-46", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 5 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-47", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 4 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 9 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-51", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-27", 8 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-25", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-29", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-7", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-29", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-55", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-3", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 3 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-30", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-8", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-30", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-10", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-31", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 7 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-31", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 5 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-32", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-9", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-32", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-12", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-33", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 11 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-33", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-34", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 9 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-34", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-18", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-35", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 15 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-35", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-16", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-36", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 13 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-36", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-59", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-37", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-38", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-19", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-38", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-20", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-38", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-82", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-38", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-25", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-39", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 19 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-39", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-29", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-4", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 17 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-40", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-28", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-40", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-70", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-41", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-72", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-42", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-71", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-43", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-76", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-44", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-75", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-45", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-74", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-46", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-73", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-47", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-54", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-48", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-21", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-49", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-78", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-50", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-77", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-51", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-37", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-52", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-166", 2 ],
					"disabled" : 0,
					"hidden" : 0,
					"midpoints" : [ 34.25, 158.0, 163.0, 158.0, 163.0, 109.0, 277.0, 109.0, 277.0, 100.0, 435.5, 100.0 ],
					"source" : [ "obj-53", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-169", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-54", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-54", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-56", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-13", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-57", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-102", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-58", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-56", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-59", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-30", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-31", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-32", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-33", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-34", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-35", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-36", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-39", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-40", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-6", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-57", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-60", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-14", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-61", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-13", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-62", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-92", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-63", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-94", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-63", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-88", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-64", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-8", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-7", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-2", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-79", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-9", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-8", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-89", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-88", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-2", 4 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-89", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-10", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-9", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-94", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-92", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-94", 0 ]
				}

			}
 ]
	}

}
