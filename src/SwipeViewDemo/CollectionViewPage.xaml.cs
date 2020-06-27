using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwipeViewDemo
{
    public class MovieItem
    {
        public string Image { get; set; }

        public int Year { get; set; }

        public string Title { get; set; }
    }

    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage()
        {
            InitializeComponent();
            _mainCollection.ItemsSource = new List<MovieItem>
            {
                new MovieItem
                {
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61bMkkwpduL._AC_SY741_.jpg",
                    Title = "IT",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://http2.mlstatic.com/posters-personalizados-spider-man-homecoming-marvel-D_NQ_NP_800103-MLM25865988027_082017-F.jpg",
                    Title = "Spider-Man: Homecoming",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://mx.web.img3.acsta.net/pictures/20/05/11/19/29/3302666.jpg",
                    Title = "Ya no estoy aquí",
                    Year = 2019
                },
                new MovieItem
                {
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61bMkkwpduL._AC_SY741_.jpg",
                    Title = "IT",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://http2.mlstatic.com/posters-personalizados-spider-man-homecoming-marvel-D_NQ_NP_800103-MLM25865988027_082017-F.jpg",
                    Title = "Spider-Man: Homecoming",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://mx.web.img3.acsta.net/pictures/20/05/11/19/29/3302666.jpg",
                    Title = "Ya no estoy aquí",
                    Year = 2019
                },
                new MovieItem
                {
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61bMkkwpduL._AC_SY741_.jpg",
                    Title = "IT",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://http2.mlstatic.com/posters-personalizados-spider-man-homecoming-marvel-D_NQ_NP_800103-MLM25865988027_082017-F.jpg",
                    Title = "Spider-Man: Homecoming",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://mx.web.img3.acsta.net/pictures/20/05/11/19/29/3302666.jpg",
                    Title = "Ya no estoy aquí",
                    Year = 2019
                },
                new MovieItem
                {
                    Image = "https://images-na.ssl-images-amazon.com/images/I/61bMkkwpduL._AC_SY741_.jpg",
                    Title = "IT",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://http2.mlstatic.com/posters-personalizados-spider-man-homecoming-marvel-D_NQ_NP_800103-MLM25865988027_082017-F.jpg",
                    Title = "Spider-Man: Homecoming",
                    Year = 2017
                },
                new MovieItem
                {
                    Image = "https://mx.web.img3.acsta.net/pictures/20/05/11/19/29/3302666.jpg",
                    Title = "Ya no estoy aquí",
                    Year = 2019
                }
            };
        }
    }
}
