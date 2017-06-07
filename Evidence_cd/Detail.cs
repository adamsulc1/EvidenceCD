using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evidence_cd
{
    public class Detail
    {
        public Detail(string tracks, long duration, string image)
        {
            tracks = _tracks;
            duration = _duration;
            image = _image;
        }
        private string _tracks;
        public string Tracks
        {
            get { return _tracks; }
            set { _tracks = value; }
        }
        private long _duration;
        public long Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}