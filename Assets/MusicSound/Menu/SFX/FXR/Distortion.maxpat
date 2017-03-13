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
		"rect" : [ 42.0, 85.0, 1096.0, 715.0 ],
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
					"id" : "obj-12",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 723.0, 136.0, 72.0, 22.0 ],
					"style" : "",
					"text" : "loadmess 1"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-10",
					"maxclass" : "preset",
					"numinlets" : 1,
					"numoutlets" : 4,
					"outlettype" : [ "preset", "int", "preset", "int" ],
					"patching_rect" : [ 633.0, 194.0, 100.0, 40.0 ],
					"preset_data" : [ 						{
							"number" : 1,
							"data" : [ 5, "obj-31", "umenu", "int", 2 ]
						}
 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-79",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 428.96875, 195.0, 124.0, 25.0 ],
					"style" : "",
					"text" : "Cutoff Freq",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 1,
					"fontsize" : 11.595187,
					"htabcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"id" : "obj-77",
					"maxclass" : "tab",
					"multiline" : 0,
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 6.755127, 249.0, 105.75, 26.0 ],
					"style" : "",
					"tabcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ],
					"tabs" : [ "Clean", "Distortion", "FiltDist" ],
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 12.0,
					"id" : "obj-67",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 4.041626, 220.5, 54.0, 20.0 ],
					"style" : "",
					"text" : "Clean",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-68",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 114.0, 195.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Low Gain",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-69",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 203.359375, 195.0, 91.0, 25.0 ],
					"style" : "",
					"text" : "Mid Gain",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 12.0,
					"id" : "obj-70",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 52.0, 220.5, 81.0, 20.0 ],
					"style" : "",
					"text" : "Filter I/O",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-71",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 14.625, 121.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Main Vol",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-72",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 396.96875, 195.0, 26.0, 25.0 ],
					"style" : "",
					"text" : "Q",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-73",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 299.640625, 195.0, 79.0, 25.0 ],
					"style" : "",
					"text" : "Hi Gain",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-74",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 432.96875, 195.0, 124.0, 25.0 ],
					"style" : "",
					"text" : "Cutoff Freq",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 12.0,
					"id" : "obj-59",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 4.041626, 220.5, 54.0, 20.0 ],
					"style" : "",
					"text" : "Clean",
					"textcolor" : [ 0.086275, 0.309804, 0.52549, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-60",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 114.0, 195.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Low Gain",
					"textcolor" : [ 0.086275, 0.309804, 0.52549, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-61",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 203.359375, 195.0, 91.0, 25.0 ],
					"style" : "",
					"text" : "Mid Gain",
					"textcolor" : [ 0.086275, 0.309804, 0.52549, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 12.0,
					"id" : "obj-62",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 47.0, 220.5, 81.0, 20.0 ],
					"style" : "",
					"text" : "Filter I/O",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-63",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 14.625, 121.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Main Vol",
					"textcolor" : [ 0.086275, 0.309804, 0.52549, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-64",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 396.96875, 195.0, 26.0, 25.0 ],
					"style" : "",
					"text" : "Q",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-65",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 299.640625, 195.0, 79.0, 25.0 ],
					"style" : "",
					"text" : "Hi Gain",
					"textcolor" : [ 0.086275, 0.309804, 0.52549, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-66",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 432.96875, 193.5, 124.0, 25.0 ],
					"style" : "",
					"text" : "Cutoff Freq",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 12.0,
					"id" : "obj-24",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 6.755127, 220.5, 54.0, 20.0 ],
					"style" : "",
					"text" : "Clean",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-37",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 116.713501, 195.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Low Gain",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-38",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 206.072876, 195.0, 91.0, 25.0 ],
					"style" : "",
					"text" : "Mid Gain",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-41",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 17.338501, 121.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Main Vol",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-42",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 399.682251, 195.0, 26.0, 25.0 ],
					"style" : "",
					"text" : "Q",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-43",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 302.354126, 195.0, 79.0, 25.0 ],
					"style" : "",
					"text" : "Hi Gain",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 1,
					"fontname" : "AR DESTINE",
					"fontsize" : 64.0,
					"id" : "obj-22",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 183.0, 76.125, 367.0, 80.0 ],
					"style" : "",
					"text" : "Distortion",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 1,
					"fontname" : "AR DESTINE",
					"fontsize" : 64.0,
					"id" : "obj-18",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 176.96875, 76.125, 367.0, 80.0 ],
					"style" : "",
					"text" : "Distortion",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 1,
					"fontname" : "Iso",
					"fontsize" : 78.0,
					"id" : "obj-7",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 14.625, 14.125, 547.53125, 96.0 ],
					"style" : "",
					"text" : "DIMENSIONAL",
					"textcolor" : [ 0.086275, 0.309804, 0.52549, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 1,
					"fontname" : "Iso",
					"fontsize" : 78.0,
					"id" : "obj-2",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 10.171875, 18.125, 547.53125, 96.0 ],
					"style" : "",
					"text" : "DIMENSIONAL",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 12.0,
					"id" : "obj-36",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 4.041626, 220.5, 54.0, 20.0 ],
					"style" : "",
					"text" : "Clean",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-34",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 114.0, 195.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Low Gain",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-33",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 203.359375, 195.0, 91.0, 25.0 ],
					"style" : "",
					"text" : "Mid Gain",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"id" : "obj-21",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 470.71875, 257.625, 42.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"id" : "obj-20",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 318.140625, 257.625, 42.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"id" : "obj-56",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 39.875, 192.5, 42.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"id" : "obj-51",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 388.96875, 257.625, 42.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"id" : "obj-49",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 227.859375, 257.625, 42.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"fontname" : "Bauhaus 93",
					"format" : 6,
					"id" : "obj-45",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 137.75, 257.625, 41.0, 26.0 ],
					"style" : "",
					"textcolor" : [ 0.960784, 0.827451, 0.156863, 1.0 ],
					"tricolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgfillcolor_angle" : 270.0,
					"bgfillcolor_autogradient" : 0,
					"bgfillcolor_color" : [ 0.290196, 0.309804, 0.301961, 1.0 ],
					"bgfillcolor_color1" : [ 0.862745, 0.741176, 0.137255, 0.0 ],
					"bgfillcolor_color2" : [ 1.0, 1.0, 1.0, 0.0 ],
					"bgfillcolor_proportion" : 0.39,
					"bgfillcolor_type" : "gradient",
					"color" : [ 0.901961, 0.8, 0.392157, 1.0 ],
					"elementcolor" : [ 0.901961, 0.8, 0.392157, 1.0 ],
					"fontface" : 2,
					"fontname" : "Bauhaus 93",
					"fontsize" : 16.0,
					"id" : "obj-31",
					"items" : [ "Supernova", ",", "Stardust", ",", "Equinox", ",", "Gamma", "Ray", ",", "Light", "Year" ],
					"maxclass" : "umenu",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 402.109375, 158.125, 134.375, 32.0 ],
					"style" : "",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-40",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 14.625, 121.0, 90.0, 25.0 ],
					"style" : "",
					"text" : "Main Vol",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-32",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 396.96875, 195.0, 26.0, 25.0 ],
					"style" : "",
					"text" : "Q",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 2,
					"fontname" : "DejaVu Sans Mono",
					"fontsize" : 16.0,
					"id" : "obj-29",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 299.640625, 195.0, 79.0, 25.0 ],
					"style" : "",
					"text" : "Hi Gain",
					"textcolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 1,
					"fontname" : "Iso",
					"fontsize" : 78.0,
					"id" : "obj-23",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1.041626, 14.125, 547.53125, 96.0 ],
					"style" : "",
					"text" : "DIMENSIONAL",
					"textcolor" : [ 0.52549, 0.062745, 0.003922, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 1,
					"fontname" : "AR DESTINE",
					"fontsize" : 64.0,
					"id" : "obj-25",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 170.9375, 76.125, 367.0, 80.0 ],
					"style" : "",
					"text" : "Distortion",
					"textcolor" : [ 0.011765, 0.396078, 0.752941, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"floatoutput" : 1,
					"id" : "obj-16",
					"maxclass" : "dial",
					"needlecolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 388.96875, 217.875, 38.5, 38.5 ],
					"size" : 1.0,
					"style" : "",
					"varname" : "Depth"
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"id" : "obj-15",
					"maxclass" : "dial",
					"needlecolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 470.71875, 217.875, 40.5, 40.5 ],
					"size" : 5000.0,
					"style" : "",
					"varname" : "Rate"
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.095481, 0.100396, 0.100293, 0.0 ],
					"id" : "obj-14",
					"maxclass" : "dial",
					"needlecolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 315.5, 217.875, 40.5, 40.5 ],
					"size" : 158.0,
					"style" : "",
					"varname" : "Dry/Wet"
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
					"needlecolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 227.859375, 217.875, 40.5, 40.5 ],
					"size" : 158.0,
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
					"needlecolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 137.75, 221.25, 39.5, 39.5 ],
					"size" : 158.0,
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
					"needlecolor" : [ 0.862745, 0.741176, 0.137255, 1.0 ],
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"outlinecolor" : [ 0.784314, 0.145098, 0.023529, 1.0 ],
					"parameter_enable" : 0,
					"patching_rect" : [ 39.875, 150.0, 40.5, 40.5 ],
					"style" : "",
					"varname" : "Vol"
				}

			}
, 			{
				"box" : 				{
					"angle" : 270.0,
					"bordercolor" : [ 0.52549, 0.062745, 0.003922, 1.0 ],
					"grad1" : [ 0.0, 0.078431, 0.321569, 1.0 ],
					"grad2" : [ 0.0, 0.0, 0.0, 1.0 ],
					"id" : "obj-55",
					"maxclass" : "panel",
					"mode" : 1,
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ -5.052124, -2.125, 567.208374, 299.5 ],
					"proportion" : 0.39,
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
					"patching_rect" : [ 413.21875, 195.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "+ 1"
				}

			}
, 			{
				"box" : 				{
					"comment" : "",
					"id" : "obj-4",
					"maxclass" : "outlet",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 253.0, 233.0, 19.0, 19.0 ],
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
					"patching_rect" : [ 169.0, 236.5, 19.0, 19.0 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-35",
					"maxclass" : "preset",
					"numinlets" : 1,
					"numoutlets" : 4,
					"outlettype" : [ "preset", "int", "preset", "int" ],
					"patching_rect" : [ 413.21875, 233.0, 68.0, 17.0 ],
					"preset_data" : [ 						{
							"number" : 1,
							"data" : [ 5, "obj-5", "dial", "float", 1.222223, 5, "obj-8", "dial", "float", 0.025316, 5, "obj-9", "dial", "float", 12.345679, 5, "<invalid>", "dial", "float", 0.734599, 5, "<invalid>", "dial", "float", 49.382717, 5, "obj-14", "dial", "float", 45.0, 5, "obj-15", "dial", "float", 0.0, 5, "obj-16", "dial", "float", 0.545455, 5, "obj-31", "umenu", "int", 0, 5, "<invalid>", "slider", "float", 0.274005, 5, "obj-45", "flonum", "float", 0.025316, 5, "<invalid>", "flonum", "float", 0.734599, 5, "<invalid>", "flonum", "float", 54.382717, 5, "obj-49", "flonum", "float", 17.345678, 5, "<invalid>", "flonum", "float", 0.274005, 5, "obj-51", "flonum", "float", 0.545455, 5, "obj-56", "flonum", "float", 1.222223, 5, "<invalid>", "toggle", "int", 1 ]
						}
, 						{
							"number" : 2,
							"data" : [ 5, "obj-5", "dial", "float", 0.777778, 5, "obj-8", "dial", "float", 0.822785, 5, "obj-9", "dial", "float", 172.839508, 5, "<invalid>", "dial", "float", 0.177215, 5, "<invalid>", "dial", "float", 154.320984, 5, "obj-14", "dial", "float", 63.0, 5, "obj-15", "dial", "float", 1.0, 5, "obj-16", "dial", "float", 0.207792, 5, "obj-31", "umenu", "int", 1, 5, "<invalid>", "slider", "float", 1.0, 5, "obj-45", "flonum", "float", 0.822785, 5, "<invalid>", "flonum", "float", 0.177215, 5, "<invalid>", "flonum", "float", 159.320984, 5, "obj-49", "flonum", "float", 177.839508, 5, "<invalid>", "flonum", "float", 2.0, 5, "obj-51", "flonum", "float", 0.207792, 5, "obj-56", "flonum", "float", 0.777778, 5, "<invalid>", "toggle", "int", 1 ]
						}
, 						{
							"number" : 3,
							"data" : [ 5, "obj-5", "dial", "float", 0.481482, 5, "obj-8", "dial", "float", 0.0, 5, "obj-9", "dial", "float", 500.0, 5, "<invalid>", "dial", "float", 0.734177, 5, "<invalid>", "dial", "float", 43.209873, 5, "obj-14", "dial", "float", 100.0, 5, "obj-15", "dial", "float", 7.0, 5, "obj-16", "dial", "float", 0.12987, 5, "obj-31", "umenu", "int", 2, 5, "<invalid>", "slider", "float", 0.163934, 5, "obj-45", "flonum", "float", 0.0, 5, "<invalid>", "flonum", "float", 0.734177, 5, "<invalid>", "flonum", "float", 48.209873, 5, "obj-49", "flonum", "float", 505.0, 5, "<invalid>", "flonum", "float", 7.163934, 5, "obj-51", "flonum", "float", 0.12987, 5, "obj-56", "flonum", "float", 0.481482, 5, "<invalid>", "toggle", "int", 1 ]
						}
, 						{
							"number" : 4,
							"data" : [ 5, "obj-5", "dial", "float", 0.493827, 5, "obj-8", "dial", "float", 0.949368, 5, "obj-9", "dial", "float", 296.296295, 5, "<invalid>", "dial", "float", 0.772152, 5, "<invalid>", "dial", "float", 339.506195, 5, "obj-14", "dial", "float", 97.0, 5, "obj-15", "dial", "float", 0.0, 5, "obj-16", "dial", "float", 0.337662, 5, "obj-31", "umenu", "int", 3, 5, "<invalid>", "slider", "float", 0.131148, 5, "obj-45", "flonum", "float", 0.949368, 5, "<invalid>", "flonum", "float", 0.772152, 5, "<invalid>", "flonum", "float", 344.506195, 5, "obj-49", "flonum", "float", 301.296295, 5, "<invalid>", "flonum", "float", 0.131148, 5, "obj-51", "flonum", "float", 0.337662, 5, "obj-56", "flonum", "float", 0.493827, 5, "<invalid>", "toggle", "int", 1 ]
						}
, 						{
							"number" : 5,
							"data" : [ 5, "obj-5", "dial", "float", 0.987654, 5, "obj-8", "dial", "float", 0.835443, 5, "obj-9", "dial", "float", 0.0, 5, "<invalid>", "dial", "float", 0.898734, 5, "<invalid>", "dial", "float", 0.0, 5, "obj-14", "dial", "float", 57.0, 5, "obj-15", "dial", "float", 10.0, 5, "obj-16", "dial", "float", 0.103896, 5, "obj-31", "umenu", "int", 4, 5, "<invalid>", "slider", "float", 0.189696, 5, "obj-45", "flonum", "float", 0.835443, 5, "<invalid>", "flonum", "float", 0.898734, 5, "<invalid>", "flonum", "float", 5.0, 5, "obj-49", "flonum", "float", 5.0, 5, "<invalid>", "flonum", "float", 10.189695, 5, "obj-51", "flonum", "float", 0.103896, 5, "obj-56", "flonum", "float", 0.987654, 5, "<invalid>", "toggle", "int", 1 ]
						}
 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"comment" : "",
					"id" : "obj-11",
					"maxclass" : "inlet",
					"numinlets" : 0,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 187.03125, 85.5, 29.4375, 29.4375 ],
					"style" : ""
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-1",
					"maxclass" : "newobj",
					"numinlets" : 8,
					"numoutlets" : 2,
					"outlettype" : [ "signal", "signal" ],
					"patching_rect" : [ 170.03125, 220.5, 103.0, 22.0 ],
					"style" : "",
					"text" : "FXDistortion"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-82",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 183.0, 152.0, 29.5, 22.0 ],
					"style" : "",
					"text" : "65"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-80",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 3,
					"outlettype" : [ "bang", "bang", "" ],
					"patching_rect" : [ 183.0, 121.0, 46.0, 22.0 ],
					"style" : "",
					"text" : "sel 1 2"
				}

			}
 ],
		"lines" : [ 			{
				"patchline" : 				{
					"destination" : [ "obj-3", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-1", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-4", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-1", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-31", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-10", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 1 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-11", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-10", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-12", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-20", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-14", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-21", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-15", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-51", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-16", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 7 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-20", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 4 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-21", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-6", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-31", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 3 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-45", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 5 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-49", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 2 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-5", 0 ]
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
					"destination" : [ "obj-1", 6 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-51", 0 ]
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
					"destination" : [ "obj-1", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-77", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-80", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-77", 0 ]
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
					"destination" : [ "obj-82", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-80", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-82", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-80", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-14", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-82", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-5", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-82", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-8", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-82", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-9", 0 ],
					"disabled" : 0,
					"hidden" : 0,
					"source" : [ "obj-82", 0 ]
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
