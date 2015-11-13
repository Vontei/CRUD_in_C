using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstDotNet.ViewModels.Album
{
    public class NewAlbumViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Artist { get; set; }
		
        public string Year { get; set; }
		
		public string Genre { get; set; }
    }
}