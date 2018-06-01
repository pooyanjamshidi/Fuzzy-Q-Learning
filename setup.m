function setup
% Setup script
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2018 Pooyan Jamshidi

disp('setting path...');
pathCell = regexp(path, pathsep, 'split');

myDir = fileparts(mfilename('fullpath'));
paths = genpath(myDir);
paths = strread(paths, '%s', 'delimiter', ':');
pathsToAdd = [];

if ispc
    del = '\';
else
    del = '/';
end

for i=1:length(paths)
    thisPath = paths{i};
    thisPathSplit = strread(thisPath, '%s', 'delimiter', del);
    addThisPath = 1;
    
    % Do not add any directories or files starting with a . or a ~ or if it
    % currently on the path
    for j=1:length(thisPathSplit)
        thisStr = thisPathSplit{j};
        if (~isempty(thisStr)) && ((thisStr(1) == '.') || (thisStr(1) == '~')) || any(strcmpi(thisPath, pathCell))
            addThisPath = 0;
        end
        
    end
    if addThisPath ==1
        if ~isempty(pathsToAdd)
            thisPath = [':' thisPath];
        end
        pathsToAdd = [pathsToAdd thisPath];
    end
end

if ~isempty(pathsToAdd)
    addpath(pathsToAdd);
end

if ispc
    rmpath('Controllers\RobusT2Scale')
else
    rmpath('Controllers/RobusT2Scale')
end
rmpath('FQL4KE')
end

% if you want to not run this when you exit matlab uncomment this, use
% this: which pathdef.m -all
%savepath;
