build:
	cp Podfile.env iosPlatform/Podfile
	cd iosPlatform; bundle exec pod install;
