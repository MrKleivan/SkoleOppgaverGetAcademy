let modell = {
    app: {
        currentPage: 'home', //movie, profile, search, preference, showMore
    },

    input: {
        home: {
            searchField: 'Dunkirk',
        },
        movie: {
            rating: 1000,
            review: '',
            isFavorite: true,
        },
        search: {
            searchField: 'Godfather', //Søke etter film || skuespiller navn
            year: 1995,
            rating: 800,
            mood: [
                'Sad', //Ref til Mood liste
            ],
            genre: [
                'war',
            ], 
        },
        profile: {
            userName: 'Tommy',
            picture: 'tommy.png',
            userQuote: 'Im single and ready to mingle',
            userLocation: 'Horten',
            userPronouns: 'He',
            isEditMode: false,
        },
        preferences: {
            genre: [],
            mood: 'Sad' //veryDepressed, happy
        }
    },

    data: {
        currentSearch: '',
        genre: [
            'war',
            'drama', 
            'action',
            'mafia',
        ],   
        bannerMovie: [
            {filmID:1, rate:900},
        ],
        topMovies:[
            {filmID: 1, rate:900},
        ],
        movies: [
            {
                filmID: 1,
                titel: 'Dunkirk',
                genre: ['war', 'drama', 'action'],
                year: 2017,
                director: 'Christopher Nolan',
                actors:[
                    {
                        name: 'Barry Keoghan',
                        headShot: 'img/...',
                        characterPlayed: 'George',
                    }
                ],
                siteRating: 899,
                userRating: 458,
                ratingCount: 28,
                description: '...',
                moviePoster: "....",
                // isFavorite: true, //Kanskje her.
            },
            {
                filmID: 2,
                titel: 'Godfather',
                genre: 'mafia', 
                year: 1972,
                director: 'Christopher Nolan',
                actors:[
                    {
                        name: 'Barry Keoghan',
                        headShot: 'img/...',
                        characterPlayed: 'George',
                    }
                ],
                siteRating: 567,
                userRating: 900,
                ratingCount: 28,
                description: '...',
                moviePoster: "....",
                
            },
        ],
        favoriteList: [
            {
                filmID: 1,
                titel: '...',
                moviePoster: 'img/...',
                siteRating: 899,
            }
        ],
        profile: {
            userName: '...',
            userPhoto: 'img/...',
            userInfo: {
                userQuote: '...',
                userLocation: '...',
                userPronouns: '...'
            },
        favoriteGenre: [
            'war',
            'thriller',
            'romantic comedies'
        ],    
        mood: {
            sad: [
            'war',
            'thriller'
            ],
            happy: [
            'romantic comedies',
            'horror'
            ],
            veryDepressed: [
            'comedy',
            'cartoons',
            'nature documentaries'
            ]
        }
        }
    },
};